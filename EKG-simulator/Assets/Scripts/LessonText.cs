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
	private string thirdAVB;
	private string twoToOneAVB;
	private string Afib;
	private string Aflutter;
	private string Ajunctional;
	private string APaced;
	private string Asystole;
	private string DualPaced;
	private string Idioventricular;
	private string AIVR;
	private string JB;
	private string junctional;
	private string junctionalTachy;
	private string NSR;
	private string SB;
	private string PJC;
	private string PAC;
	private string PVC;
	private string SA;
	private string SArrest;
	private string ST;
	private string STElevation;
	private string SVT;
	private string Torsades;
	private string Vfib;
	private string VPaced;
	private string Vtach;



	void Start(){

		// grabs text element from this
		text = GetComponent<UnityEngine.UI.Text> ();

		// attaches StripGenerator script to stripGenerator
		stripGenerator = GameObject.Find ("StripGenerator").GetComponent<StripGenerator> ();

		DefineLessons ();
		SetLesson ();

	

	}

	// sets the lesson text to the variable passed in. adds the source
	void PrintLesson(string tag){
		text.text = tag + source;
	}
		

	void SetLesson(){

		switch (StripGenerator.Strip.tag) {

		case "1stAVB":
			PrintLesson(firststAVB);
			break;

		case "2ndAVB1":
			PrintLesson(secondAVB1);
			break;

		case "2ndAVBII":
			PrintLesson(secondAVBII);
			break;

		case "3rdAVB":
			PrintLesson(thirdAVB);
			break;

		case "2:1AVB":
			PrintLesson(twoToOneAVB);
			break;

		case "Afib":
			PrintLesson(Afib);
			break;

		case "Aflutter":
			PrintLesson(Aflutter);
			break;

		case "AJunctional":
			PrintLesson(Ajunctional);
			break;

		case "APaced":
			PrintLesson(APaced);
			break;

		case "Asystole":
			PrintLesson(Asystole);
			break;

		case "DualPaced":
			PrintLesson(DualPaced);
			break;

		case "Idioventricular":
			PrintLesson(Idioventricular);
			break;

		case "AIVR":
			PrintLesson (AIVR);
			break;

		case "JB":
			PrintLesson(JB);
			break;

		case "Junctional":
			PrintLesson(junctional);
			break;

		case "JunctionalTachy":
			PrintLesson(junctionalTachy);
			break;

		case "NSR":
			PrintLesson(NSR);
			break;

		case "PJC":
			PrintLesson(PJC);
			break;

		case "SB":
			PrintLesson (SB);
			break;

		case "PAC":
			PrintLesson(PAC);
			break;

		case "PVC":
			PrintLesson(PVC);
			break;

		case "SA":
			PrintLesson(SA);
			break;

		case "SArrest":
			PrintLesson(SArrest);
			break;

		case "ST":
			PrintLesson(ST);
			break;

		case "STElevation":
			PrintLesson(STElevation);
			break;

		case "SVT":
			PrintLesson(SVT);
			break;

		case "Torsades":
			PrintLesson(Torsades);
			break;

		case "Vfib":
			PrintLesson(Vfib);
			break;

		case "VPaced":
			PrintLesson(VPaced);
			break;

		case "Vtach":
			PrintLesson(Vtach);
			break;

		default:
			PrintLesson("No lesson here yet!");
			break;

		}

	}


	void DefineLessons(){

		firststAVB = "First-degree AV block \n\n" +
			"First-degree AV block is a prolonged PR interval that" +
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
	
		secondAVB1 = "2nd-degree AV block type 1 (Wenkebach) \n\n" +
			"2nd-degree AVB type 1 Usually a transient block, Wenckebach usually lasts only a few days." +
			" It occurs when the AV node becomes progressively weaker and less able to conduct" +
			" the sinus impulses until finally it is unable to send the impulse down to the ventricle " +
			"at all. As a result, the PR intervals grow progressively longer until there is a P wave" +
			" that has no QRS behind it.\n\nRate\nAtrial rate usually 60 to 100; ventricular" +
			" rate less than the atrial rate due to nonconducted beats.\n \nRegularity\nUsually " +
			"irregular, but can look regular but interrupted at times. A hallmark of Wenckebach" +
			" is groups of beats, then a pause.\n \nP waves\nNormal sinus P waves. All Ps except" +
			" the blocked P are followed by a QRS. P-P interval is regular. There may be P waves" +
			" that are hidden in the QRS complex or the T wave. Find two consecutive P waves and " +
			"then march out where the rest of the P waves are, keeping in mind they will all have" +
			" the same P-P interval, so they'll all be the same distance apart.\n \nIntervals" +
			"\nPR gradually prolongs until a QRS is dropped.\n\nQRS <0.12 secs\n \nCause" +
			"\nMyocardial infarction (MI), digitalis toxicity, medication side effects\n" +
			" \nAdverse effects\nUsually no ill effects. Watch for worsening block.\n " +
			"\nTreatment\nPrepare for transcutaneous pacing if signs of decreased cardiac output exist." +
			" Administer atropine if a pacemaker is not immediately available and the patient" +
			" is symptomatic. Most patients with Wenckebach require nothing more than cautious" +
			" observation. ";

		secondAVBII = "Mobitz II Second-Degree AV Block\n\nMobitz II is a block caused" +
			" by an intermittent block at the AV node or the bundle branches, preventing " +
			"some sinus impulses from getting to the ventricles. With AV node block, the " +
			"resultant QRS complexes will be narrow. With block at the bundle branches," +
			" the QRS will be wide. Usually, Mobitz II patients already have a bundle " +
			"branch block, meaning that one of their bundle branches does not let impulses" +
			" through. They are therefore dependent on the other bundle branch to conduct " +
			"the impulses through to the ventricles. If that other bundle branch becomes " +
			"suddenly blocked, then none of the sinus impulses can get through. Sinus P" +
			" waves therefore conduct through to the ventricles when the one bundle branch " +
			"is open, but they don't get through at all when both bundle branches are" +
			" blocked. When the impulses do get through, they do so with an unchanging " +
			"PR interval every time. Bottom line: Mobitz II second-degree AV block looks" +
			" like a sinus rhythm with all P waves in place, but with some QRS-Ts " +
			"removed.\n\nRate\nAtrial rate usually 60 to 100; ventricular rate less" +
			" than atrial rate due to dropped beats.\n \nRegularity\nMay be regular, " +
			"irregular, or regular but interrupted.\n \nP waves\nNormal sinus P waves." +
			" All Ps except the blocked Ps have a QRS behind them. P-P interval is regular." +
			" Some P waves may be hidden inside QRS complexes or T waves.\n \nIntervals" +
			"\nPR constant on the conducted beats.\n\nQRS <0.12 secs if the block is at" +
			" the AV node; ≥0.12 secs if the block is at the bundle branches.\n \nCause" +
			"\nMI, conduction system lesion, medication side effect, hypoxia.\n \nAdverse" +
			" effects\nSince the heart rate can be very slow, the patient may have signs" +
			" of decreased cardiac output. Mobitz II can progress to third-degree block " +
			"if untreated.\n \nTreatment\nImmediate transcutaneous pacing. Start oxygen. " +
			"May try atropine or an epinephrine or dopamine infusion first if a pacemaker" +
			" is not readily available. Depending on where the block is, atropine may" +
			" not work. Atropine speeds up the rate of sinus node firing and improves " +
			"AV node conduction. If the block is at the AV node, atropine will improve" +
			" conduction, and the impulse will travel on down the pathway unimpeded. " +
			"If the block is at the bundle branches, however, the impulse will blast " +
			"through the AV node and head down the pathway only to find that both bundle" +
			" branches are still blocked. Atropine has no effect on the bundle branches." +
			" So bottom line: With Mobitz II and narrow QRS (<0.12 secs), atropine " +
			"should work. With wide QRS (≥0.12 secs), epinephrine may be a better choice.\n ";

		thirdAVB = "3rd-degree AV block\n\n" +
			"In third-degree AV block, the sinus node sends out its impulses as usual," +
			" but none of them ever gets to the ventricles because there is a complete block at" +
			" the AV node or the bundle branches. Meanwhile, the AV node and the ventricle are " +
			"waiting patiently for the sinus impulses to reach them. When it's obvious that the " +
			"sinus impulse isn't coming, one of the lower pacemakers escapes and assumes pacemaking " +
			"control to provide a QRS complex. If the block is at the AV node, a lower spot in the " +
			"AV junction should take over as pacemaker and provide a heart rate of 40 to 60. If the" +
			" block is at the bundle branches, the only pacemaker left below that is the ventricle, " +
			"which then assumes control with a heart rate of 20 to 40. Even though the lower" +
			" pacemaker has assumed control of providing the QRS complex, the sinus node is" +
			" unaware of that, so it continues firing out its impulses as usual, providing P" +
			" waves.\n\nRate\nAtrial rate usually 60 to 100; ventricular rate usually 20 to " +
			"60.\n \nRegularity\nRegular\n \nP waves\nNormal sinus P waves; P-P interval is" +
			" regular; P waves may be hidden inside QRS complexes or T waves. P waves are not " +
			"associated with any of the QRS complexes, even though there may at times appear " +
			"to be a relationship. This is called AV dissociation, and it is a hallmark of" +
			" third-degree block. AV dissociation means that the sinus node is firing at its " +
			"normal rate, and the lower pacemaker is firing at its slower rate, and the two " +
			"have nothing to do with each other. AV dissociation results in independent " +
			"beating of the atria and the ventricles.\n\nImagine the lower pacemaker that " +
			"controls the ventricles as an old man jogging around a circular racetrack at " +
			"2 miles per hour. The sinus node is an 18-year-old boy sprinting at 4 miles " +
			"per hour. Since the boy is going faster than the old man, he will periodically " +
			"catch up with him and then pass him. An onlooker might see the boy at the split" +
			" second he's side by side with the old man and assume they are together and that " +
			"there is a relationship between the two. There isn't, of course. Their being side" +
			" by side was just coincidence, just as it's coincidence that a sinus P wave might" +
			" land right in front of a QRS in third-degree AV block and make it seem as though " +
			"there is a relationship there.\n \nIntervals\nPR varies.\n\nQRS narrow (<0.12 secs) " +
			"or wide (>0.12 secs) depending on the location of the block. If the block is at the" +
			" AV node, the AV junction should become the pacemaker and the QRS will be narrow." +
			" If the block is at the bundle branches, the ventricle will become the pacemaker," +
			" with a wide QRS.\n \nCause\nMI, conduction system lesion, medication side effects," +
			" hypoxia.\n \nAdverse effects\nSigns of low cardiac output may occur if the heart " +
			"rate is slow enough.\n \nTreatment\nTranscutaneous pacing is indicated if the " +
			"patient is symptomatic. Atropine, epinephrine, or dopamine can be given until a " +
			"more permanent transvenous pacemaker can be inserted if needed. Start oxygen.\n ";

		twoToOneAVB = "2:1 AV block \n\n" +
			"2:1 AV block is a type of second-degree block in which there are two P" +
			" waves to each QRS complex. The first P wave in each pair of P waves is blocked." +
			" 2:1 AV block can be caused by either Wenckebach or Mobitz II.\n\nRate\nAtrial " +
			"rate 60 to 100; ventricular rate half the atrial rate\n \nRegularity\nRegular\n " +
			"\nP waves\nNormal sinus P waves; two Ps to each QRS; P-P interval regular\n " +
			"\nIntervals\nPR constant on the conducted beats\n\nQRS <0.12 secs if the block " +
			"is at the AV node; ≥0.12 secs if the block is at the bundle branches\n \nCause" +
			"\nSame as Wenckebach or Mobitz II\n \nAdverse effects\nDecreased cardiac output" +
			" if the heart rate is too slow.\n \nTreatment\nTranscutaneous pacing if the " +
			"patient has symptoms of decreased cardiac output. May try atropine or an " +
			"epinephrine or dopamine infusion first if a pacemaker is not readily available. " +
			"Start oxygen. ";

		Afib = "Atrial Fibrillation\n\nDuring atrial fibrillation, hundreds of atrial " +
			"impulses from different locations all fire at the same time. As a result, " +
			"the atria depolarize not as a unit as they usually do, but rather in small" +
			" sections. This causes the atria to wiggle instead of contract. The AV" +
			" node is bombarded with all these impulses and simply cannot depolarize " +
			"fast enough to let them all through. Every now and then one of these impulses" +
			" does get through to the ventricle and provides a QRS.\n\nRate\nAtrial " +
			"rate is 350 to 700; ventricular rate varies. Atrial fibrillation with a" +
			" mean ventricular rate >100 is said to have RVR (rapid ventricular response)." +
			" Remember ventricular rate is the same as heart rate.\n \nRegularity" +
			"\nIrregularly irregular, completely unpredictable\n \nP waves\nNo P waves are " +
			"present. Fibrillatory waves are present instead. These are undulations or" +
			" waviness of the baseline between QRSs. If there are P waves, the rhythm" +
			" is not atrial fibrillation.\n \nIntervals\nSince there are no P waves, " +
			"there is no PR interval.\n\nQRS <0.12 secs\n \nCause\nMI, lung disease," +
			" valvular heart disease, hyperthyroidism\n \nAdverse effects\nAtrial" +
			" fibrillation can cause a drop in cardiac output because of the loss " +
			"of the atrial kick, which accounts for 15% to 30% of the cardiac output." +
			" One possible complication of atrial fibrillation is blood clots, which" +
			" can collect in the sluggish atria. This can result in MI, strokes, or" +
			" blood clots in the lung.\n \nTreatment\nDepends on the duration of " +
			"atrial fibrillation. Since the atria are wiggling, not contracting, blood " +
			"flow is stagnant and clots can develop. If there are atrial clots and " +
			"the rhythm is converted back to sinus, the restored atrial contraction " +
			"(atrial kick) can dislodge these clots, propelling them out of the atrium " +
			"into the circulation.\n\nIf atrial fibrillation duration is less than 48 " +
			"hours, the goal is to convert the rhythm back to sinus. Digitalis, calcium" +
			" channel blockers, beta-blockers, amiodarone, or electrical cardioversion " +
			"can be utilized. In atrial fibrillation less than 48 hours old, the " +
			"likelihood that there are blood clots in the atria is low, so there is" +
			" minimal chance of showering clots to the brain, heart, lungs, and other" +
			"organs once the atrial kick is reestablished in sinus rhythm.\n\nIn stable" +
			" patients who have been in atrial fibrillation for greater than 48 hours," +
			" the risk of blood clots is greater, so initial treatment is aimed at " +
			"controlling the heart rate rather than converting the rhythm back to sinus." +
			"Anticoagulants (blood thinners) are given to prevent any more blood clots " +
			"from forming, and cardioversion is delayed 2 to 3 weeks to allow any clots" +
			" that are there to dissolve on their own. Meanwhile, medications can be" +
			" given to regulate the heart rate to a more normal level. In emergencies," +
			" patients in atrial fibrillation greater than 48 hours will be started on" +
			" heparin (an anticoagulant) intravenously, given a transesophageal" +
			" echocardiogram (TEE—a sonarlike test using a probe inserted into the esophagus)" +
			" to rule out blood clots in the atria, then electrically cardioverted." +
			" Consider starting oxygen. ";

		Aflutter = "Atrial Flutter\n\nAtrial flutter is a rhythm that results when one " +
			"irritable atrial focus fires out regular impulses at a rate so rapid that a" +
			" fluttery pattern is produced instead of P waves. The atrium is firing out " +
			"its impulses so fast that the AV node, bombarded with all these impulses, " +
			"lets some through but blocks others. Imagine a tennis ball machine firing " +
			"out tennis balls so fast that there's no way you can hit them all. You end" +
			"up ducking to protect yourself. The AV node is the gatekeeper—the protector—of " +
			"the ventricles. Impulses must pass through it to reach the ventricles. Impulses " +
			"that are too fast would provide a dangerously fast heart rate, so the AV node" +
			" selectively blocks out some of the impulses, letting only some through.\n\nRate" +
			"\nAtrial rate 250 to 350. Ventricular rate depends on the conduction ratio.\n " +
			"\nRegularity\nRegular if the conduction ratio (ratio of flutter waves to QRS " +
			"complexes) is constant; irregular if the conduction ratio varies; can look regular " +
			"but interrupted at times\n \nP waves\nNo P waves present. Flutter waves are present" +
			" instead. These are sawtooth-shaped waves between the QRS complexes. Flutter waves " +
			"are also described as picket-fence-shaped, V-shaped, or upside-down-V shaped. There" +
			" will be 2 or more flutter waves to each QRS. All flutter waves march out—they're" +
			" all the same distance apart. Flutter waves are regular. They do not interrupt" +
			" themselves to allow a QRS complex to pop in. Some flutter waves will therefore" +
			" be hidden inside QRS complexes or T waves. The easiest way to find all the " +
			"flutter waves is to find 2 flutter waves back-to-back and note the distance between" +
			" them (go from top to top of the flutter waves or bottom to bottom). Then march " +
			"out where the rest of the flutter waves should be using this interval. Although" +
			"most flutter waves will be easily visible using this method, some will not be" +
			" as obvious, as they are hidden inside the QRS or the T wave. Even though you" +
			" can't see these flutter waves, they are there and they still count.\n" +
			" \nIntervals\nPR not measured, since there are no real P waves\n\nQRS <0.12 secs\n " +
			"\nCause\nAlmost always implies heart disease; other causes include pulmonary " +
			"embolus, valvular heart disease, thyrotoxicosis, or lung disease\n \nAdverse " +
			"effects\nCan be well tolerated at normal heart rates; at higher or lower rates," +
			" signs of decreased cardiac output can occur. Cardiac output is influenced not " +
			"by the atrial rate, but by the heart rate.\n \nTreatment\nDigitalis, calcium " +
			"channel blockers, beta-blockers, adenosine, carotid sinus massage (rubbing the " +
			"carotid artery in the neck to stimulate the vagus nerve) to slow the ventricular" +
			" rate. Electrical cardioversion can be done if medications are ineffective or" +
			" the patient is unstable. ";

		Ajunctional = "Accelerated Junctional Rhythm\n\nAccelerated junctional " +
			"rhythm can occur because of escape or usurpation. If the sinus node " +
			"slows down, the AV junction can escape and take over as the pacemaker." +
			" Or an irritable spot in the AV junction can usurp control from the slower " +
			"sinus node and become the heart's pacemaker at a faster-than-normal rate." +
			"\n\nRate\n60 to 100\n \nRegularity\nRegular\n \nP waves\nInverted before " +
			"or after the QRS, or hidden inside the QRS\n \nIntervals\nPR <0.12 secs if" +
			" the P precedes the QRS\n\nQRS <0.12 secs\n \nCause\nHeart disease," +
			" stimulant drugs, and caffeine\n \nAdverse effects\nUsually none because " +
			"the heart rate is within normal limits\n \nTreatment\nUsually none required" +
			" aside from removal of the cause ";

		APaced = "No lesson here yet! ";

		Asystole = "Asystole\n\nAsystole is flat-line EKG. Every one of the heart's" +
			" pacemakers has failed.\n\nRate\nZero\n \nRegularity\nNone\n \nP waves" +
			"\nNone\n \nIntervals\nNo PR interval since no P waves; no QRS interval " +
			"since no QRS\n \nT wave\nNone\n \nCause\nProfound cardiac or other body " +
			"system damage; profound hypoxia. Even with vigorous resuscitative efforts," +
			" this is usually a terminal rhythm.\n \nAdverse effects\nDeath if untreated\n" +
			" \nTreatment\nAtropine to reverse any vagal influence, epinephrine and/or " +
			"vasopressin, CPR, oxygen. There is rarely a need to utilize a pacemaker. " +
			"Depending on the situation, it may be appropriate to forgo resuscitative efforts. ";

		DualPaced = "No lesson here yet! ";

		Idioventricular = "Idioventricular Rhythm (IVR)\n\nIdioventricular rhythm (IVR) is a " +
			"rhythm originating in the ventricle at its inherent rate. Higher pacemakers have" +
			" failed, so the ventricle escapes to save the patient's life.\n\nRate\n20 to 40\n" +
			" \nRegularity\nRegular\n \nP waves\nNone\n \nIntervals\nPR not applicable\n\nQRS" +
			" interval >0.12 secs; QRS wide and bizarre\n \nT wave\nSlopes off in the opposite" +
			" direction to the QRS\n \nCause\nUsually implies massive cardiac or other damage, " +
			"hypoxia\n \nAdverse effects\nDecreased cardiac output, cardiovascular collapse. " +
			"IVR may or may not result in a pulse.\n \nTreatment\nAtropine, epinephrine," +
			" pacemaker, oxygen, dopamine. If the patient is pulseless, do CPR. ";

		AIVR = "Accelerated Idioventricular Rhythm (AIVR)\n\nAccelerated idioventricular" +
			" rhythm (AIVR) is a rhythm originating in the ventricle, with a heart rate " +
			"faster than the ventricle's normal rate. It can result from escape or " +
			"usurpation.\n\nRate\n40 to 100\n \nRegularity\nUsually regular, but can " +
			"be a little irregular at times\n \nP waves\nUsually not seen\n \nIntervals" +
			"\nNo PR interval since no P waves\n\nQRS interval >0.12 secs; QRS wide and " +
			"bizarre\n \nT wave\nSlopes off in the opposite direction to the QRS\n " +
			"\nCause\nVery common after an MI. Can be caused by the same factors that" +
			" cause PVCs. AIVR is also common after administration of thrombolytic " +
			"(clot-dissolving) medications, and in that context it was once considered " +
			"a reperfusion arrhythmia, implying the heart muscle was once again getting" +
			" blood flow after the clot was dissolved. Current studies, however, have " +
			"shown that AIVR occurs just as often without reperfusion as with it, so" +
			" it's no longer considered a sign of reperfusion.\n \nAdverse effects" +
			"\nUsually no ill effects because the heart rate is close to normal\n" +
			" \nTreatment\nCould be treated with atropine if the patient is symptomatic." +
			" Consider starting oxygen. Usually no treatment is necessary as AIVR tends" +
			" to be a self-limiting rhythm. ";

		JB = "Junctional Bradycardia\n\nJunctional bradycardia is a junctional " +
			"rhythm with a heart rate slower than usual. A higher pacemaker" +
			" has failed, and the AV junction has to escape to save the patient's " +
			"life.\n\nRate\n<40\n \nRegularity\nRegular\n \nP waves\nInverted before" +
			" or after the QRS, or hidden inside the QRS\n \nIntervals\nPR <0.12 secs" +
			" if the P precedes the QRS\n\nQRS <0.12 secs\n \nCause\nVagal stimulation," +
			" hypoxia, ischemia of the sinus node, heart disease\n \nAdverse effects" +
			"\nSlow heart rate can cause decreased cardiac output.\n \nTreatment" +
			"\nPrepare for immediate transcutaneous pacing (attaching a pacemaker " +
			"to the patient's skin). If the pacemaker is not immediately available " +
			"and the patient is symptomatic, give atropine or consider starting an " +
			"epinephrine or dopamine infusion to increase the heart rate. Start oxygen." +
			" Stop any heart rate-slowing medications.\n ";

		junctional= "Junctional Rhythm\n\nJunctional rhythm is a rhythm that " +
			"originates in the AV junction at its inherent rate of 40 to 60." +
			" It is usually an escape rhythm.\n\nRate\n40 to 60\n \nRegularity" +
			"\nRegular\n \nP waves\nInverted before or after the QRS, or hidden" +
			"inside the QRS\n \nIntervals\nPR <0.12 secs if the P precedes the " +
			"QRS\n\nQRS <0.12 secs\n \nCause\nVagal stimulation, hypoxia, sinus " +
			"node ischemia, heart disease\n \nAdverse effects\nUsually none if the heart" +
			" rate is closer to the 50s to 60s range. Signs of decreased cardiac" +
			" output are possible at slower heart rates.\n \nTreatment\nTranscutaneous " +
			"pacing, atropine, dopamine or epinephrine infusion if symptomatic " +
			"from the slow heart rate. Withdraw or decrease any medications that can " +
			"slow the heart rate. Consider starting oxygen. ";

		junctionalTachy= "Junctional Tachycardia\n\nAn irritable spot in the AV" +
			" junction has taken over as the pacemaker, and the heart rate is" +
			" very rapid. This is usually a result of usurpation. Junctional " +
			"tachycardia is best called SVT if there are no visible P waves, " +
			"as the origin of the rhythm is not identifiable.\n\nRate\n>100\n " +
			"\nRegularity\nRegular\n \nP waves\nInverted before or after the QRS," +
			" or hidden inside the QRS\n \nIntervals\nPR <0.12 secs if the P" +
			" precedes the QRS\n\nQRS <0.12 secs\n \nCause\nMost often caused by " +
			"digitalis toxicity, but can be caused by heart disease, stimulants, " +
			"or sympathetic nervous system stimulation\n \nAdverse effects\nDecreased " +
			"cardiac output possible if the heart rate is fast enough\n \nTreatment" +
			"\nBeta-blockers, calcium channel blockers, adenosine.\n\nConsider " +
			"starting oxygen. Electrical cardioversion can be done if the patient is unstable. ";

		NSR= "Sinus Rhythm\n\nSinus rhythm is the normal rhythm. The impulse" +
			" is born in the sinus node and heads down the conduction pathway " +
			"to the ventricle. Every P wave is married to a QRS complex, and the heart " +
			"rate is the normal 60 to 100. The QRS complex can be positive, negative," +
			" or isoelectric depending on the lead being monitored.\n\nRate\n60-100\n " +
			"\nRegularity\nRegular\n \nP waves\nUpright in most leads, although may be " +
			"normally inverted in V1. One P to each QRS. All P waves have the same shape." +
			" All matching upright P waves are sinus P waves until proven otherwise " +
			"(this is the most crucial criterion to identifying rhythms originating in " +
			"the sinus node); P-P interval is regular.\n \nIntervals\nPR 0.12 to 0.20" +
			" secs, constant from beat to beat QRS <0.12 secs\n \nCause\nNormal\n " +
			"\nAdverse effects\nNone (unless the heart rate is a drastic change from" +
			" previously—always look at the trend).\n \nTreatment\nNone ";

		SB = "Sinus Bradycardia\n\nSinus bradycardia is a slower-than-normal rhythm from" +
			" the sinus node. The impulse originates in the sinus node and travels the" +
			" conduction system normally. The QRS complex can be positive, negative, " +
			"or isoelectric depending on the lead being monitored.\n\nRate\nLess than" +
			" 60\n \nRegularity\nRegular\n \nP waves\nUpright in most leads, although" +
			" may be inverted in V1. One P to each QRS. P waves shaped the same." +
			" P-P interval regular.\n \nIntervals\nPR 0.12 to 0.20 secs, constant" +
			" from beat to beat QRS <0.12 secs\n \nCause\nVagal stimulation such" +
			" as vomiting or straining to have a bowel movement, myocardial " +
			"infarction (MI), hypoxia (low blood oxygen level), digitalis " +
			"toxicity (an overabundance of the medication digitalis in the" +
			" bloodstream), and other medication side effects. Sinus bradycardia" +
			" is common in athletes because their well-conditioned heart pumps" +
			" more blood out with each beat and therefore doesn't need to beat" +
			" as often.\n \nAdverse effects\nToo slow a heart rate can cause signs" +
			" of decreased cardiac output. Many individuals, however, tolerate a " +
			"slow heart rate and do not require treatment.\n \nTreatment\nNone unless" +
			" the patient is symptomatic. A medication called atropine can be used if" +
			" needed to speed up the heart rate. Atropine increases the rate at which " +
			"the sinus node propagates (creates) its impulses and speeds up impulse " +
			"conduction through the AV node. Thus, it causes an increase in heart rate." +
			" If atropine is unsuccessful, an electronic pacemaker or medications such" +
			" as epinephrine and dopamine can be utilized, although they are not usually " +
			"necessary for sinus bradycardia unless the individual is in shock. Consider" +
			" starting oxygen. If the heart does not receive adequate oxygen, conduction" +
			" system cells become ischemic (oxygen starved) and may respond by firing at" +
			" rates above or below their norm. Providing supplemental oxygen can help" +
			" these stricken cells return to more normal" +
			" functioning and a more normal heart rate. ";

		PJC= "Premature Junctional Complexes (PJCs)\n\nPremature junctional complexes " +
			"(PJCs) are premature beats that originate in the AV junction before the" +
			" next sinus beat is due. This is caused by irritable tissue in the AV " +
			"junction firing and usurping the sinus node for that beat.\n\n[Figure 9-2." +
			" PJC.]\n\nRate\nCan occur at any rate\n \nRegularity\nRegular but interrupted\n" +
			" \nP waves\nInverted before or after the QRS, or hidden inside the QRS\n " +
			"\nIntervals\nPR <0.12 secs if the P wave precedes the QRS\n\nQRS <0.12 secs\n" +
			" \nCause\nStimulants (such as caffeine or drugs), nicotine, hypoxia, heart" +
			" disease\n \nAdverse effects\nUsually no ill effects\n \nTreatment\nUsually " +
			"none required aside from removal of the cause ";

		PAC= "Premature Atrial Complexes (PACs)\n\nPremature atrial complexes (PACs) are" +
			" premature beats that are fired out by irritable atrial tissue before the " +
			"next sinus beat is due. The premature P wave may or may not be followed by " +
			"a QRS, depending on how premature the PAC is. If the PAC is very premature," +
			" it will not be conducted to the ventricle because it will arrive during the" +
			" ventricle's refractory period.\n\nRate\nCan occur at any rate\n \nRegularity" +
			"\nRegular but interrupted (by the PACs)\n \nP waves\nShaped differently from " +
			"sinus P waves. The premature P waves of PACs may be hidden in the T wave of" +
			" the preceding beat. If so, they will deform the shape of that T wave. Always " +
			"be suspicious when a T wave suddenly changes shape. If the QRS complexes look the" +
			" same, then the T waves that belong to them should also look the same. If one T" +
			" wave is different, there's probably a P wave hiding in it. If the PAC's P wave" +
			" is inverted, the PR interval should be the normal 0.12 to 0.20 secs.\n \nIntervals" +
			"\nPR 0.12 to 0.20 secs\n\nQRS <0.12 secs\n\nQRS will be absent after a nonconducted" +
			" PAC. The most common cause of an unexplained pause is a nonconducted PAC. If you" +
			" see a pause and you're tempted to call it a sinus arrest or sinus block, make " +
			"sure there's no P hiding in the T wave inside the pause. It might just be a " +
			"nonconducted PAC.\n \nCause\nThe atria become \"hyper\" and fire early," +
			" before the next sinus beat is due. This can be caused by medications " +
			"(stimulants, caffeine, bronchodilators), tobacco, hypoxia, or heart disease." +
			" Occasional PACs are normal.\n \nAdverse effects\nFrequent PACs can be an " +
			"early sign of impending heart failure or impending atrial tachycardia or atrial" +
			" fibrillation. Patients usually have no ill effects from occasional PACs.\n " +
			"\nTreatment\nUsually none needed. Omit caffeine, tobacco, and other stimulants." +
			" Can give digitalis, calcium channel blockers, or beta blockers to treat PACs" +
			" if needed. These medications all slow the heart rate and can decrease atrial " +
			"irritability, decreasing PACs and other atrial arrhythmias. Treat heart failure " +
			"if present. Consider starting oxygen. ";

		PVC= "Premature Ventricular Complexes (PVCs)\n\nPremature ventricular complexes" +
			" (PVCs) are premature beats that originate in irritable ventricular tissue" +
			" before the next sinus beat is due.\n\nRate\nCan occur at any rate\n " +
			"\nRegularity\nRegular but interrupted\n \nP waves\nUsually not seen on " +
			"PVCs\n \nIntervals\nPR not applicable\n\nQRS interval >0.12 secs; QRS" +
			" wide and bizarre in shape\n \nT wave\nSlopes off in the opposite direction" +
			"to the QRS. If the QRS points upward, for example, the T wave will point" +
			" downward.\n \nCause\nThe big three causes are heart disease, hypokalemia " +
			"(low blood potassium level), and hypoxia. Other causes include low blood magnesium level," +
			" stimulants, caffeine, stress, or anxiety. All these factors can cause the " +
			"ventricle to become irritable and fire early beats.\n \nAdverse effects" +
			"\nOccasional PVCs are of no concern. Frequent PVCs (6 or more per minute)" +
			" or PVCs that are close to or land on the downstroke of the previous beat's" +
			" T wave (called R-on-T phenomenon) can progress to lethal arrhythmias such" +
			" as ventricular tachycardia or ventricular fibrillation. Multifocal PVCs " +
			"(those with differing shapes) are also cause for concern, since they mean " +
			"that there are multiple irritable areas.\n \nTreatment\nOccasional PVCs don't " +
			"require treatment. They can occur in normal, healthy individuals. If PVCs are" +
			" more frequent, treat the cause. For example, if the potassium level is low," +
			" give supplemental potassium. Start oxygen. Amiodarone, an antiarrhythmic" +
			" medication used to treat both atrial and ventricular arrhythmias, may be" +
			" used to treat PVCs. For frequent PVCs during a slow bradycardia, however," +
			" do not treat with antiarrhythmics; treat with atropine instead. Bradycardic" +
			" rhythm PVCs are the heart's attempt to increase the heart rate by providing " +
			"another beat from somewhere. Giving antiarrhythmics could knock out the PVCs," +
			" leaving a slower heart rate. Atropine would speed up the underlying rhythm " +
			"and the PVCs should go away on their own. ";

		SArrest= "Sinus Arrest\n\nSinus arrest is a pause that occurs when the regularly " +
			"firing sinus node suddenly stops firing for a brief period. One or more" +
			" P-QRS-T sequences will be missing. An escape beat from a lower pacemaker " +
			"may then take over for one or more beats. The sinus node may resume" +
			" functioning after missing one or more beats, or the lower pacemaker" +
			" may continue as the pacemaker, creating a new escape rhythm. The pause" +
			" is not a multiple of the previous R-R intervals. The escape beat or" +
			" rhythm resumes whenever it can. The QRS complex can be positive, negative," +
			" or isoelectric depending on the lead being monitored.\n\nRate\nCan occur " +
			"at any heart rate\n \nRegularity\nRegular but interrupted (by a pause)." +
			" In any rhythm with a pause, always measure the length of the pause in " +
			"seconds.\n \nP waves\nNormal sinus P waves before the pause, normal or " +
			"different-shaped Ps (if even present) on the beat ending the pause. P-P " +
			"interval is usually regular before the pause and may vary after the pause," +
			" depending on whether the sinus node regains pacemaking control.\n" +
			" \nIntervals\nPR 0.12 to 0.20 secs before the pause, may be shorter or" +
			" absent after the pause.\n\nQRS on the sinus beats will be <0.12 secs." +
			" On the escape beat(s), the QRS may be narrow (<0.12 secs) or wide (>0.12 secs)" +
			" depending on which pacemaker of the heart resumes following the pause.\n " +
			"\nCause\nSinus node ischemia, hypoxia, digitalis toxicity, excessive vagal" +
			" tone, other medication side effects.\n \nAdverse effects\nFrequent or very" +
			" long sinus arrests can cause decreased cardiac output.\n \nTreatment" +
			"\nOccasional sinus arrests may not cause a problem—the patient has no " +
			"ill effects. Frequent sinus arrests may require that the medication causing" +
			" it be stopped and can require atropine and/or a pacemaker to speed up the" +
			" heart rate. Consider starting oxygen. ";

		SA= "Sinus Arrhythmia\n\nSinus arrhythmia is the only irregular rhythm from the " +
			"sinus node, and it has a pattern that is cyclic and usually corresponds with" +
			" the breathing pattern. The QRS complex can be positive, negative, or" +
			" isoelectric depending on the lead being monitored.\n\nRate\nVaries with " +
			"respiratory pattern—faster with inspiration, slower with expiration. The" +
			" negative pressure in the chest during inspiration sucks up blood from the" +
			" lower extremities, causing an increase in blood returning to the right" +
			" atrium. The heart rate speeds up to circulate this extra blood. Sinus" +
			" arrhythmia is especially common during sleep, especially among those" +
			" with sleep apnea (a temporary, often repetitive cessation of breathing " +
			"during sleep).\n \nRegularity\nIrregular in a repetitive pattern; longest " +
			"R-R cycle exceeds the shortest by ≥0.16 secs (four or more little blocks)." +
			"\n \nP waves\nUpright in most leads, although may be inverted in V1. P " +
			"waves shaped the same. One P to each QRS. P-P interval is irregular.\n " +
			"\nIntervals\nPR 0.12 to 0.20 secs, constant from beat to beat QRS <0.12" +
			" secs\n \nCause\nUsually caused by the breathing pattern, but can be " +
			"caused by heart disease\n \nAdverse effects\nUsually no ill effects\n " +
			"\nTreatment\nUsually none required ";

		SVT= "Supraventricular Tachycardia (SVT)\n\nSupraventricular tachycardia (SVT)" +
			" is a catchall term given to tachycardias that are supraventricular; that" +
			" is, they originate above the ventricles (the prefix supra- means \"above\") " +
			"in either the sinus node, the atrium, or the AV junction, but whose exact " +
			"origin cannot be identified because P waves are not discernible.\n\nRate\nAbout " +
			"130 or higher (usually > 150)\n \nRegularity\nRegular\n \nP waves\nNot " +
			"discernible\n \nIntervals\nPR cannot be measured since P waves cannot be" +
			" positively identified.\n\nQRS <0.12 secs\n \nCause\nSame as PAT\n " +
			"\nAdverse effects\nDecreased cardiac output secondary to the rapid heart rate\n" +
			" \nTreatment\nAdenosine, digitalis, ibutilide (a medication to control atrial" +
			" arrhythmias), calcium channel blockers, beta-blockers. Consider starting" +
			" oxygen. Elective cardioversion can also be done if the patient is unstable. ";

		STElevation= "ST Segment\n\nThe normal ST segment should be on the baseline at" +
			" the same level as the PR segment. (Think of the PR segment as the baseline " +
			"for ST segment evaluation purposes.) Abnormal ST segments can be elevated or " +
			"depressed. To see if the ST segment is elevated or depressed, draw a straight " +
			"line extending from the PR segment out past the QRS. An elevated ST segment is" +
			" one that is above this line. A depressed ST segment is one that is below this " +
			"line. ST segment elevation implies myocardial injury. ST elevation can be either " +
			"concave or convex. Convex ST segment elevation (also called a coved ST segment) " +
			"is most often associated with a STEMI in progress. Concave ST elevation is often " +
			"associated with pericarditis, an inflammation of the pericardium and the " +
			"myocardium immediately beneath it, but it can also be seen in STEMIs. ST " +
			"depression implies ischemia or reciprocal changes opposite the area of infarct. ";

		ST= "Sinus Tachycardia\n\nSinus tachycardia is a rhythm in which the sinus node" +
			" fires at a heart rate faster than normal. The impulse originates in the " +
			"sinus node and travels down the conduction pathway normally. The QRS complex" +
			" can be positive, negative, or isoelectric depending on the lead being monitored." +
			"\n\nRate\n101 to 160. According to most experts, the sinus node does not fire " +
			"at a rate above 160 in supine resting adults. Although this is somewhat" +
			" controversial, we will adopt 160 as the upper limit of the sinus node." +
			" All strips in this text are from supine resting adults unless otherwise" +
			" specified.\n \nRegularity\nRegular\n \nP waves\nUpright in most leads, " +
			"although may be inverted in V1. One P to each QRS. P waves shaped the same. " +
			"P-P interval regular.\n \nIntervals\n0.12 to 0.20 secs, constant from beat " +
			"to beat QRS <0.12 secs\n \nCause\nMedications such as atropine or bronchodilators " +
			"(medications used to open up narrowed respiratory passages in patients with" +
			" asthma or chronic obstructive pulmonary disease [COPD]); emotional upset," +
			" pulmonary embolus (blood clot in the lung), MI, congestive heart failure" +
			" (CHF), fever, inhibition of the vagus nerve, hypoxia, and thyrotoxicosis" +
			" (thyroid storm—an emergent medical condition in which the thyroid gland " +
			"overproduces thyroid hormones so that the heart rate, blood pressure, and " +
			"temperature all rise to dangerously high levels)\n \nAdverse effects\nIncreased " +
			"heart rate causes increased cardiac workload. The faster a muscle works, " +
			"the more blood and oxygen it requires. This can stress an already weakened heart." +
			" Cardiac output can drop. This is especially true in the patient with an" +
			" acute MI, as the increased blood and oxygen demand taxes the already damaged " +
			"heart muscle.\n \nTreatment\nTreat the cause. For example, if the patient" +
			" in sinus tachycardia has a fever, give medications to decrease the fever." +
			" If the tachycardia is caused by anxiety, consider sedation. For cardiac" +
			" patients with persistent sinus tachycardia, a class of medications " +
			"called beta-blockers may be used to slow the heart rate. Consider starting" +
			" oxygen to decrease the heart's workload. ";

		Torsades= "Torsades de Pointes\n\nTorsades de pointes (pronounced tor-sahd de point)" +
			" is a French term meaning \"twisting of the points.\" It's a form of polymorphic" +
			" (multiple-shaped) ventricular tachycardia that is recognized primarily by its" +
			" classic shape—it oscillates around an axis, with the QRS complexes pointing up," +
			" then becoming smaller, then rotating around until they point down. Torsades is" +
			" not usually well tolerated in longer bursts and often deteriorates into ventricular" +
			" fibrillation.\n\nRate\n>200\n \nRegularity\nMay be regular or irregular\n " +
			"\nP waves\nNone seen\n \nIntervals\nPR not applicable\n\nQRS >0.12 secs, often" +
			" hard to measure; QRS wide and bizarre QT interval on a pre-torsades strip " +
			"will be prolonged.\n \nT wave\nOpposite the QRS, but may not be seen due to " +
			"the rapidity of the rhythm\n \nCause\nCan be caused by antiarrhythmic " +
			"medications such as quinidine, procainamide, or amiodarone, which cause an " +
			"increased QT interval. Otherwise it is caused by the same factors that cause" +
			" V-tach.\n \nAdverse effects\nMay be tolerated for short runs, but usually " +
			"results in cardiac arrest if sustained\n \nTreatment\nIntravenous magnesium" +
			" is the usual treatment. Electrical cardioversion or defibrillation may be" +
			" needed. Start oxygen. ";

		Vfib= "Ventricular Fibrillation (V-fib)\n\nIn ventricular fibrillation (V-fib)," +
			" hundreds of impulses in the ventricle are firing, each depolarizing its own " +
			"little piece of territory. As a result, the ventricles wiggle instead of contract." +
			" The heart's electrical system is in chaos, and the resultant rhythm looks" +
			" like static.\n\nRate\nCannot be counted\n \nRegularity\nNone detectable\n" +
			" \nP waves\nNone\n \nIntervals\nNo PR interval since no P waves\n\nNo" +
			" QRS interval since no QRS complexes—just a wavy or spiked baseline\n" +
			" \nT wave\nNone\n \nCause\nSame as V-tach; also can be caused by drowning, " +
			"drug overdoses, accidental electric shock\n \nAdverse effects\nProfound " +
			"cardiovascular collapse. There is no cardiac output whatsoever. There is no pulse," +
			" no breathing, nothing. The patient is functionally dead. New onset V-fib has " +
			"coarse fibrillatory waves. These waves get progressively finer the longer" +
			" it lasts.\n \nTreatment\nImmediate defibrillation (electric shock to the heart)" +
			", epinephrine, CPR, amiodarone, lidocaine, oxygen. The rhythm will not be" +
			" converted with just medications. Defibrillation must be done. The medications" +
			" make the defibrillation more successful and can prevent recurrences of V-fib.\n ";

		VPaced= "V-paced \n\n" +
			"No lesson here yet! ";

		Vtach= "Ventricular Tachycardia (V-tach)\n\nIn ventricular tachycardia (V-tach)," +
			" an irritable ventricular focus has usurped the sinus node to become the" +
			" pacemaker and is firing very rapidly.\n\nRate\n>100\n \nRegularity\nUsually " +
			"regular, but can be a little irregular at times\n \nP waves\nUsually none seen," +
			" but dissociated from the QRS if present\n \nIntervals\nVariable PR if even " +
			"present\n\nQRS >0.12 secs; QRS wide and bizarre\n \nT wave\nSlopes off in the" +
			" opposite direction to the QRS\n \nCause\nSame as PVCs\n \nAdverse effects\nThis" +
			" rhythm may be tolerated for short bursts, but prolonged runs of V-tach can" +
			" cause profound shock, unconsciousness, and death if untreated.\n \nTreatment" +
			"\nAmiodarone or lidocaine intravenously if the patient is stable. Electric " +
			"shock to the heart (cardioversion or defibrillation) is indicated if the" +
			" patient is unstable or pulseless. Also treat the cause (low potassium," +
			" magnesium, or oxygen levels, etc.). CPR is indicated if the patient is pulseless. ";





		source = "\n\n " +
			"SOURCE: \n\n" +
			"Ellis, Karen M., author.\n   " +
			"EKG plain and simple / Karen M. Ellis, RN," +
			" Touro Infirmary, " +
			"New Orleans.—Third edition.\n " +
			"          p.; cm.";
	}


}
