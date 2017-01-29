using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;		// for text elements

public class LessonTextManager : MonoBehaviour {


	public GameObject lessonPreFab;	// attached in unity, holds the lesson componenets
	public GameObject lessonClone;	// lessonPreFab instantiated as lessonClone


	void Start(){


	}

	// this gets called by the button scrip
	public void ShowLesson(){

		lessonClone = Instantiate (lessonPreFab, transform.position, Quaternion.identity) as GameObject;
		lessonClone.transform.SetParent (transform, false);

	}


	// TODO DOESNT work!!!!!!!!
	public void CloseLesson(){
		Destroy (lessonClone);
		Debug.Log ("closelesson!");
	}

}
