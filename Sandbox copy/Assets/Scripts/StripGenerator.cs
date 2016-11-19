using UnityEngine;
using System.Collections;
using UnityEngine.UI;			// for buttons and canvas elements

public class StripGenerator : MonoBehaviour {

	public GameObject[] StripArray;		// array of EKG strips. Attached in editor.
	private int StripArraySize;			// holds max number of items in StripArray
	public static GameObject Strip;			// strips are isntantiated as Strip GameObjects
	public GameObject grid;				// holds stripGrid, attached in editor
	private GameObject gridNow;			// grid instantiates into gridNow below




	// Use this for initialization
	void Start () {
		StripArraySize = StripArray.Length;		// sets StripArraySize to number of items in StripArray
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

		if (TimeKeeper.gameStarted == true){				// if the game has started
			if (transform.childCount == 0) {
				//Debug.Log ("no strip");
				int nextStripPointer = Random.Range (0, StripArraySize);
				Strip = Instantiate (StripArray [nextStripPointer], transform.position, Quaternion.identity) as GameObject;
				Strip.transform.parent = transform;
			}
		}
	}

	public static void DestroyStrip(){
		Destroy (Strip);			// destroy current strip
	}




}
