using UnityEngine;
using System.Collections;
using UnityEngine.UI;			// for UI elements

public class Strips : MonoBehaviour {
	private Animator animator;			// animator component 
	private Text heartRateText;				// HR indicator text
	private int hR;						// holds HR for each strip
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
		FindHR ();		// sets HR based on tag of strip
		DisplayHR();	// sets HR to text element in game
	}

	// sets HR based on the strip's tag
	void FindHR(){	
		switch (this.tag) {
		case "Afib":
			hR = 160;
			break;

		case "NSR":
			hR = 80;
			break;

		case "ST":
			hR = 130;
			break;

		case "SB":
			hR = 50;
			break;


		case "SA":
			hR = 80;
			break;


		case "SArrest":
			hR = 80;
			break;


		case "PAC":
			hR = 90;
			break;

		case "Aflutter":
			hR = 80;
			break;

		case "SVT":
			hR = 155;
			break;

		case "PJC":
			hR = 90;
			break;

		case "JB":
			hR = 40;
			break;

		case "Junctional":
			hR = 55;
			break;

		case "AJunctional":
			hR = 70;
			break;

		case "JunctionalTachy":
			hR = 105;
			break;

		case "PVC":
			hR = 90;
			break;

		case "Idioventricular":
			hR = 30;
			break;

		case "AIVR":
			hR = 40;
			break;

		case "Vtach":
			hR = 180;
			break;

		case "Torsades":
			hR = 230;
			break;

		case "Vfib":
			hR = 0;
			break;

		case "Asystole":
			hR = 0;
			break;

		case "DualPaced":
			hR = 65;
			break;

		case "VPaced":
			hR = 70;
			break;

		case "APaced":
			hR = 85;
			break;

		case "1stAVB":
			hR = 65;
			break;

		case "2ndAVB1":
			hR = 55;
			break;

		case "2ndAVBII":
			hR = 55;
			break;


		case "2:1AVB":
			hR = 40;
			break;

		case "3rdAVB":
			hR = 30;
			break;

		case "STElevation":
			hR = 60;
			break;


		default:
			hR = 500;		// if you see this in game, strip tag not set
			break;
		}
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
