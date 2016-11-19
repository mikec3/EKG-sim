using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	public void DestroyMe() {
		Destroy (this);
		Debug.Log ("Destroy me!");
	}
}
