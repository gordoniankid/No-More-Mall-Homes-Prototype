using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0, 90, 0);
	}
	
	// Update is called once per frame
	}

}
