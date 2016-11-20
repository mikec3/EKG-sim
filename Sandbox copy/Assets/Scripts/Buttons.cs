using UnityEngine;
using System.Collections;
using UnityEngine.UI;		// for canvas and UI

public class Buttons : MonoBehaviour {

	public ValidationSpawner validationSpawner;		// validation spawner attached below
	public StripGenerator stripGenerator;		// stripGenerator attached below



	// Use this for initialization
	void Start () {
		validationSpawner = GameObject.Find ("Validation Spawner").GetComponent<ValidationSpawner> ();
		stripGenerator = GameObject.Find ("StripGenerator").GetComponent<StripGenerator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonPressed(string name){

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
			stripGenerator.GenerateStrip(name);	
		}

	}

}
