using UnityEngine;
using System.Collections;
using UnityEngine.UI;			// for UI elements

public class Strips : MonoBehaviour {
	private Animator animator;			// animator component 
	private Text heartRateText;				// HR indicator text
	public int hR;						// holds HR for each strip, edit in Unity
	public static bool mouseOver;		// bool for when mouse is hovering over strip

	// Use this for initialization
	void Start () {

		animator = this.GetComponent<Animator> ();	// attaches animator

		// attaches HRText in the game to heartRate in this script 
		// dynamically adding text component
		heartRateText = GameObject.Find("HRText").GetComponent<UnityEngine.UI.Text>();
		
		//animator.enabled = true;				
	}
	
	// Update is called once per frame
	void Update () {
		GameStatus ();	// checks to see if game start,stop, paused
		DisplayHR();	// sets HR to text element in game
	}





	void DisplayHR(){
		heartRateText.text = hR.ToString();	// displays hR variable in heartRateText as string
	}

	void GameStatus(){
		// stops animator if game paused, starts animator if game NOT paused
		if (TimeKeeper.paused) {
			animator.enabled = false;
		} else {
			animator.enabled = true;
		}
	}
		

	void OnMouseOver(){		// collider trigger attached to this
		// stops animator when mouse over strip
		animator.enabled = false;
		mouseOver = true;			// static mouseOver bool true
	}

	void OnMouseExit(){
		// restarts animation when mouse leaves strip
		animator.enabled = true;
		mouseOver = false;			// static mouseOver bool false
	}
}
