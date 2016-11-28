﻿using UnityEngine;
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

		CreateButtons ();		// Instatiate buttons
	
	}
	// Update is called once per frame
	void Update () {
	
	}

	void CreateButtons(){

		// instantiate the answerButton as a GameObject
		for (int x = 0; x < buttonArray.Length; x++) {
			
			answerButton = Instantiate (buttonArray [x], transform.position, Quaternion.identity) as GameObject;
			// set answerButton's parent as buttonSpawner, worldPositionStays is false
			answerButton.transform.SetParent (parentPanel, false);	

			Button myButton = answerButton.GetComponent<Button> ();	// Allows answerButton to become a UI button

			// adds onclick event listener, performs buttonPressed function sends button tag to buttonPressed
			myButton.GetComponent<Button> ().onClick.AddListener (() => buttonPressed (myButton.tag));

		}
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