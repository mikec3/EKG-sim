using UnityEngine;
using System.Collections;
using UnityEngine.UI;			// for buttons and canvas elements

public class StripGenerator : MonoBehaviour {

	public GameObject[] StripArray;		// array of EKG strips. Attached in editor.
	public GameObject[] StripArray2;	// attached in editor. holds second set of strips
	private int StripArraySize;			// holds max number of items in StripArray
	public static GameObject Strip;			// strips are isntantiated as Strip GameObjects
	public GameObject grid;				// holds stripGrid, attached in editor
	private GameObject gridNow;			// grid instantiates into gridNow below
	private ButtonSpawner buttonSpawner;	// attached below, tells buttons when to spawn




	// Use this for initialization
	void Start () {
		StripArraySize = StripArray.Length;		// sets StripArraySize to number of items in StripArray
		buttonSpawner = GameObject.Find("Button Spawner").GetComponent<ButtonSpawner>();
	}
	
	// Update is called once per frame
	void Update () {

		AutoGenerateStrip ();		// Instantiates strips
		Grid();						// displays/destroys grid
	
	}

	/* if static bool mouseOver in Strips is TRUE AND the strip generator has
	 * less than 2 children, then the stripGrid will instantiate as gridNow
	 * set gridNow as a child of stripGenerator. Destroy gridNow when mouse leaves
	 * strip.
	 * */
	void Grid(){
		if (Strips.mouseOver && transform.childCount < 2) {
			gridNow = Instantiate (grid, transform.position, Quaternion.identity) as GameObject;
			gridNow.transform.parent = transform;
		} if (!Strips.mouseOver) {
			Destroy (gridNow);
		}
	}



	void AutoGenerateStrip(){
		/* If game has started and
		 * If StripGenerator has no children, then instantiates a randomly chosen strip from the 
		 * strip array, sets it to GameOBject Strip and makes it a child of StripGenerator
		 * */

		GameObject[] arr = RandomArray ();	// randomly chooses striparray or striparray2

		MakeTheDamStrip (arr);				// passes the randomly chosen array to be created
	}

	GameObject[] RandomArray(){
		// Randomly chooses striparray or striparray2 and returns the selected array
		if (Random.Range (0, 2) < 1) {
			return StripArray;
		}
		else return StripArray2;

	}

	void MakeTheDamStrip(GameObject[] arr){

		if (TimeKeeper.gameStarted == true) {				// if the game has started
			if (transform.childCount == 0) {
				//Debug.Log ("no strip");
				int nextStripPointer = Random.Range (0, StripArraySize);
				Strip = Instantiate (arr [nextStripPointer], transform.position, Quaternion.identity) as GameObject;
				Strip.transform.parent = transform;

				// tells buttonSpawner to create the random answer buttons
				buttonSpawner.CreateRandomAnswerButtons ();
			}
		}

	}



	public static void DestroyStrip(){
		Destroy (Strip);			// destroy current strip
	}

	public void GenerateStrip(string tag){
		// takes tag from button (passed to it from button script), looks through entire StripArray and 
		// finds the strip.tag that matches, then instantiates that strip.
		//Debug.Log (tag + "button pressed");
		DestroyStrip();
		for (int i = 0; i < StripArray.Length; i++) {	// iterates over StripArray[] for entire lengh
			if (StripArray [i].tag == tag) {			// if tag passed in matches tag of strip in array
				Debug.Log (StripArray [i].tag);
				Strip = Instantiate (StripArray [i], transform.position, Quaternion.identity) as GameObject;
				Strip.transform.parent = transform;
			}
		}
				
				
			}





}
