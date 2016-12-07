using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour {
	public float Speed = 2;
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
		Camera mycam = GetComponent<Camera>();
		transform.LookAt(mycam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, mycam.nearClipPlane)), Vector3.up);

	}
}
