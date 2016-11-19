using UnityEngine;
using System.Collections;

public class ValidationSpawner : MonoBehaviour {

	public GameObject[] validation;		// array attached in editor 0=wrong, 1=right
	private GameObject indicator;		// instantiated below as validation

	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	/* instantiates a "right!" or "wrong!" answer prefab at the validationSpawner,
	 * sets the right/wrong as the child of the validationSpawner. Stored right/wrong
	 * in an array 0=wrong, 1=right, gets index from button script.
	 * */
	public void ShowValidation(int index){
		
		indicator = Instantiate (validation[index], transform.position, Quaternion.identity) as GameObject;
		indicator.transform.SetParent (transform, true);
		Destroy (indicator, .7f);	// destroy indicator after float seconds.
	}





}
