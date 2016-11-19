using UnityEngine;
using System.Collections;
using UnityEngine.UI;		// for canvas and UI

public class ScoreKeeper : MonoBehaviour {

	public static float correct = 0;			// correct guesses
	public static float inCorrect = 0;		// INCORRECT guesses
	public Text text;						// text attached in editor for score
	public Text stats;						// stats text attached in editor
	private TimeKeeper timeKeeper;			// uses the gameTime from TimeKeeper
	private float shortTimer;				// holds timeLeft if game stopped early

	// Use this for initialization
	void Start () {
		timeKeeper = GameObject.Find ("Timer").GetComponent<TimeKeeper> ();	// attaches TimeKeeper
	
	
	}
	
	// Update is called once per frame
	void Update () {

		text.text = correct.ToString ();	// displays score as game is played

		if (TimeKeeper.finished) {		// if game finished, reset score.
			ResetScore ();
		} else {
			shortTimer = timeKeeper.timeLeft;	// shortTimer holds timeLeft before it's erased

		}


			
	
	}

	void ResetScore(){
		DisplayStats ();
		correct = 0;				// reset score to 0
		inCorrect = 0;				// reset score to 0
		TimeKeeper.finished = false;		// restart game

	}

  void DisplayStats(){		// creates a % correct and displays it @ text stats
		float gameStat = Mathf.Round((correct / (correct + inCorrect)) * 100);	// % correct
		float secPerStrip = Mathf.Round((timeKeeper.gameTime - shortTimer) / correct); // strip/second
		stats.text = 
			"Correct: " + correct + "\n" +
		"Accuracy: " + gameStat + "% \n" +
		"Sec/Strip: " + secPerStrip + "sec";			// game stats displayed
	}

	public void EraseStats(){
		stats.text = null;				// creates empty stats box
	}
}
