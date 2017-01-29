using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	LessonTextManager lessonManager;		// instance of LessonTextManager

	void Start(){
		// attaches the LessonTextManager script
		lessonManager = GameObject.Find ("LessonTextManager").GetComponent<LessonTextManager>();
	}

	public void DestroyMe() {
		// destroys the lessonClone (lesson background+text) upon button press.
		Destroy (lessonManager.lessonClone);

	}
}
