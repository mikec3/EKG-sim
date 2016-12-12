using UnityEngine;
using System.Collections;
using UnityEngine.UI;		// for canvas elements

public class ButtonSpawner : MonoBehaviour {

	private GameObject answerButton;			// buttonArray instantiated into answerButton
	public RectTransform parentPanel;		// attached in unity, panel holds layout group
	public GameObject[] buttonArray;			// holds array of buttons

	public ValidationSpawner validationSpawner;		// validation spawner attached below
	public StripGenerator stripGenerator;		// stripGenerator attached below
	private ScoreKeeper scoreKeeper;			// ScoreKeeper attached below

	// Use this for initialization
	void Start () {

		validationSpawner = GameObject.Find ("Validation Spawner").GetComponent<ValidationSpawner> ();
		stripGenerator = GameObject.Find ("StripGenerator").GetComponent<StripGenerator> ();
		scoreKeeper = GameObject.Find ("ScoreKeeper").GetComponent<ScoreKeeper> ();

		CreateAllButtons ();		// initialize scene with all buttons displayed
	
	}
	// Update is called once per frame
	void Update () {
	
	}

	 public void CreateRandomAnswerButtons(){
		DestroyAllButtons (); 		// destroy all over buttons first
		int totalAnswers = 5;		// stores total amount of answers to be displayed
		int topAnswers = Random.Range(0,totalAnswers);
		int bottomAnswers = totalAnswers - topAnswers;

		RandomAnswersLoop (topAnswers);	// creates random amount of answers above correct answer

		CorrectAnswerLoop ();			// creates correct answer

		RandomAnswersLoop (bottomAnswers);	// creates random amoutn of answers below correct


	}

	public void CorrectAnswerLoop(){
		// loops through entire buttonArray
		for (int x = 0; x < buttonArray.Length; x++) {

			// if button at index matches strip on screen, create the button.
			if (buttonArray [x].tag == StripGenerator.Strip.tag) {
				
				CreateButtons (x);	// create the correct answer button only


			}
		}

	}

	public void RandomAnswersLoop(int randomNumber){
		
		// for loop lasts as long as the randomNumber assigned to it
		for (int y = 0; y < randomNumber; y++) {
			
			// creates a random index pointer from 0 to total array length
			int indexPointer = Random.Range (0, buttonArray.Length);

			// if the randomly chosen button DOES NOT match the strip on display, create the button
			if (!(buttonArray [indexPointer].tag == StripGenerator.Strip.tag && DuplicateButtons(indexPointer))) {


					//creates button at the random index pointer
					CreateButtons (indexPointer);
				
			} else
				{ y--; 
				}		

		}
	}

	public bool DuplicateButtons(int indexer){

		// for every child of parentPanel
		foreach (Transform child in parentPanel.transform) {
			if (child.gameObject.tag == buttonArray [indexer].tag) {
				Debug.Log (buttonArray [indexer].tag + " duplicate answer found");
				return true;
			} else {
				return false;
			}
		}
		return false;
	}

	public void DestroyAllButtons(){
		// for every transform in parentPanel, Destroy all children!!
		foreach (Transform child in parentPanel.transform) {
			GameObject.Destroy(child.gameObject);
		}
	}

	public void CreateAllButtons(){
		DestroyAllButtons ();

		// sends x to be index while creating buttons
		for (int x = 0; x < buttonArray.Length; x++) {
			CreateButtons (x);

		}
	}

	public void CreateButtons(int index){
		
		// Instantiate buttonArray using index sent to this function into answerButton as GameObject
		answerButton = Instantiate (buttonArray [index], transform.position, Quaternion.identity) as GameObject;

		// set answerButton's parent as buttonSpawner, worldPositionStays is false
		answerButton.transform.SetParent (parentPanel, false);	

		Button myButton = answerButton.GetComponent<Button> ();	// Allows answerButton to become a UI button

		// adds onclick event listener, performs buttonPressed function sends button tag to buttonPressed
		myButton.GetComponent<Button> ().onClick.AddListener (() => buttonPressed (myButton.tag));
	}


	void buttonPressed(string name){
		if (TimeKeeper.gameStarted) {	// if game is started
			/* when button pressed, passes button name from editor to string name,
		 * compares name to tag. Performs functions if guess is correct or incorrect
		 * */
			if (name == StripGenerator.Strip.tag) {	// if name matches Strip tag (correct guess)

				ScoreKeeper.correct++;		// adds a correct guess
				validationSpawner.ShowValidation (1);	// right answer indicator

				StripGenerator.DestroyStrip ();		// calls DestroyStrip() from StripGenerator
			} else {		// if incorrect guess

				ScoreKeeper.inCorrect++;	// adds an INCORRECT guess
				validationSpawner.ShowValidation (0);	// wrong answer indicator 

				Debug.Log ("missed: " + StripGenerator.Strip.tag);	// for future stats
			}
		} else {						// if game not yet started
			//Debug.Log(name + "button pressed");
			// passes the name on the button to the StripGenerator GenerateStrip method
			scoreKeeper.EraseStats();			// erases stats for learnMode
			stripGenerator.GenerateStrip(name);	
		}
		
	}

			
				
}
