using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;		// for UI elements

public class LessonText : MonoBehaviour {

	private StripGenerator stripGenerator;		// attached below
	Text text;									// reference for text element

	private string source;
	private string firststAVB;
	private string secondAVB1;
	private string secondAVBII;
	private string thirrdAVB;
	private string twoToOneAVB;
	private string Afib;
	private string Aflutter;
	private string Ajunctional;
	private string APaced;



	void Start(){

		// grabs text element from this
		text = GetComponent<UnityEngine.UI.Text> ();

		// attaches StripGenerator script to stripGenerator
		stripGenerator = GameObject.Find ("StripGenerator").GetComponent<StripGenerator> ();

		DefineLessons ();
		SetLesson ();

	

	}

	// destroy's the lesson text display when the CloseIcon button (x) is pressed
	public void Close(){

		Destroy (gameObject);

		// Debug.Log ("close " + this);

	}
		

	void SetLesson(){

		switch (StripGenerator.Strip.tag) {

		case "1stAVB":
			text.text = firststAVB;
			break;

		default:
			text.text = "No lesson here yet!";
			break;

		}

	}


	void DefineLessons(){

		firststAVB = "First-degree AV block is a prolonged PR interval that" +
			" results from a delay in the AV node's conduction of sinus impulses " +
			"to the ventricle. All the sinus impulses do get through; they just take " +
			"longer than normal because the AV node is ischemic or otherwise suppressed. " +
			" Rate\nCan occur at any rate\n " +
			"\nRegularity\nDepends on the underlying rhythm.\n" +
			" \nP waves\nUpright, matching; one P to each QRS\n" +
			" \nIntervals\nPR prolonged (>0.20 secs), constant QRS <0.12 secs\n" +
			" \nCause\nAV node ischemia, digitalis toxicity or a side effect of other medications " +
			"such as beta-blockers or calcium channel blockers. This is a benign type of block, but" +
			" be alert for worsening AV block. First-degree AV block is seen only with rhythms " +
			"originating in the sinus node.\n \nAdverse effects\nThe first-degree AV" +
			" block itself causes no symptoms." ;
	




		source = "Ellis, Karen M., author.\n   " +
			"EKG plain and simple / Karen M. Ellis, RN," +
			" Touro Infirmary, " +
			"New Orleans.—Third edition.\n " +
			"          p.; cm.";
	}


}
