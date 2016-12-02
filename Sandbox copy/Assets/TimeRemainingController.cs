using UnityEngine;
using System.Collections;
using UnityEngine.UI;			// for UI elements

public class TimeRemainingController : MonoBehaviour {

	private Animator animator;		// holds animator component

	private TimeKeeper timeKeeper;	// holds timeKeeper

	// Use this for initialization
	void Start () {

		animator = this.GetComponent<Animator> ();	// animator component attached

		timeKeeper = GameObject.Find ("Timer").GetComponent<TimeKeeper> ();	// attached TimeKeeper script
	
	}
	
	// Update is called once per frame
	void Update () {


		// Turns Time Remaining animation On/Off according to gameStarted and paused
		if (TimeKeeper.gameStarted == false && TimeKeeper.paused == false){
			animator.enabled = false;
		} else {
			animator.enabled = true;
		}
	
	}
}
