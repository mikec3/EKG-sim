using UnityEngine;
using System.Collections;
using UnityEngine.UI;		// for canvas and UI

public class Buttons : MonoBehaviour {

	public ValidationSpawner validationSpawner;		// validation spawner attached below
	public StripGenerator stripGenerator;		// stripGenerator attached below
	private ScoreKeeper scoreKeeper;			// ScoreKeeper attached below




	// Use this for initialization
	void Start () {
		validationSpawner = GameObject.Find ("Validation Spawner").GetComponent<ValidationSpawner> ();
		stripGenerator = GameObject.Find ("StripGenerator").GetComponent<StripGenerator> ();
		scoreKeeper = GameObject.Find ("ScoreKeeper").GetComponent<ScoreKeeper> ();



	}
	
	// Update is called once per frame
	void Update () {
	
	}


		

}
