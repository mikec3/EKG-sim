using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;		// for text elements

public class LessonTextManager : MonoBehaviour {


	public GameObject lessonTextBackground;		// attached in editor, background image
	private GameObject lessonTextBackgroundClone;	// holds instantiated background
	public GameObject lessonText;				// attached in editor, text gameObject


	void Start(){


	}

	public void ShowLesson(){
		DisplayBackground ();
		DisplayText ();
	}

	void DisplayBackground(){
		//Instantiates the lessonTextBackground as a clone (for deleting and instantiating purposes)
	
		lessonTextBackgroundClone = Instantiate (lessonTextBackground, transform.position, Quaternion.identity)as GameObject;
		lessonTextBackgroundClone.transform.SetParent (transform, false);

	}

	void DisplayText(){

		GameObject textElement;
		textElement = Instantiate (lessonText, transform.position, Quaternion.identity) as GameObject;
		textElement.transform.SetParent (lessonTextBackgroundClone.transform, true);

	}
}
