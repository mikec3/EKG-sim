using UnityEngine;
using System.Collections;
using UnityEngine.UI;			// for canvas elements

public class TimeKeeper : MonoBehaviour {
	public float gameTime;		// length of gameplay in seconds. edit in editor.
	public float timeLeft;		// increments timer
	public Text text;			// time remaining text attached in editor
	private float minutes;
	private float seconds;
	public static bool finished = false;	// stores when game is finished
	public static bool paused = false;		// stores if game is on pause

	public static bool gameStarted;		// stores if game has started
	private ButtonSpawner buttonSpawner;	// attached below, spawns buttons.

	// Use this for initialization
	void Start () {
		// attaches ButtonSpawner
		buttonSpawner = GameObject.Find("Button Spawner").GetComponent<ButtonSpawner>();

		finished = false;			// game is not yet finished
		gameStarted = false;		// game has not yet started
		timeLeft = gameTime;
		CreateTime ();
		DisplayTime ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if(gameStarted == true && paused == false){	// if the game has started and not paused
		CountDown ();		// timer
		}
	}
		

	void CountDown(){
		finished = false;				// if we're counting down, then game is not finished
		timeLeft -= Time.deltaTime;		// decrements time every frame
		CreateTime();
		DisplayTime();

	}

	void DisplayTime(){
		text.text = string.Format("{0:0}:{1:00}", minutes, seconds);	// sets to string&text

	}

	void CreateTime(){
		minutes = Mathf.Floor(timeLeft / 60);	// creates minutes
		seconds = timeLeft % 60;				// creates seconds

		if (minutes <= 0 && seconds <= 0) {
			TimeUp ();
		}
	}

	void TimeUp(){
		ResetTimer ();			// resets time
	}

	public void ResetTimer(){		// button triggers
		gameStarted = false;		// stop game
		finished = true;			// triggers ScoreKeeper to reset score
		timeLeft = gameTime;		// reset timer to original game time
		CreateTime ();				
		DisplayTime ();		
		StripGenerator.DestroyStrip ();		// destroy last strip
		buttonSpawner.CreateAllButtons();

	}

	public void StartGame(){		// start game
		if (!paused) {
			StripGenerator.DestroyStrip ();	// destroy strip if game NOT paused
		}
		TimeKeeper.gameStarted = true;		// gameStarted static bool is true
		paused = false;						// paused static bool is false
	}

	public void PauseGame(){		// pause button, pauses game
		paused = true;
	}


	// pretty sure this never gets used
	public void StopGame(){			// stop game
		TimeKeeper.gameStarted = false;
		paused = false;
	}




}
//	public float timeLeft = 300.0f;
//	public bool stop = true;
//
//	private float minutes;
//	private float seconds;
//
//	public Text text;
//
//	public void startTimer(float from){
//		stop = false;
//		timeLeft = from;
//		Update();
//		StartCoroutine(updateCoroutine());
//	}
//
//	void Update() {
//		if(stop) return;
//		timeLeft -= Time.deltaTime;
//
//		minutes = Mathf.Floor(timeLeft / 60);
//		seconds = timeLeft % 60;
//		if(seconds > 59) seconds = 59;
//		if(minutes < 0) {
//			stop = true;
//			minutes = 0;
//			seconds = 0;
//
//		}
//		//        fraction = (timeLeft * 100) % 100;
//	}
//
//	private IEnumerator updateCoroutine(){
//		while(!stop){
//			text.text = string.Format("{0:0}:{1:00}", minutes, seconds);
//			yield return new WaitForSeconds(0.2f);
//		}
//	}

