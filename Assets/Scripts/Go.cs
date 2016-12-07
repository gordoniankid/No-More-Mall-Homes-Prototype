using UnityEngine;
using System.Collections;

public class Go : MonoBehaviour {
	Animator myAnimator;
	int animState;

	// Use this for initialization
	void Start () {
		myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.W)) {
			animState = 1;
		}
			myAnimator.SetInteger("currentState",animState);
	}
}
