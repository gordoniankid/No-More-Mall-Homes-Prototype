using UnityEngine;
using System.Collections;

public class Move2 : MonoBehaviour {
	public float jumpForce = 300;
	public float Speed = 2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.F))
		{
			Debug.Log("Jump!");
			GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
		}

		if(Input.GetKey(KeyCode.W))
		{


			GetComponent<Rigidbody>().AddForce(Vector3.forward * Speed);
		}

		if (Input.GetKey(KeyCode.S))
		{

			GetComponent<Rigidbody>().AddForce(Vector3.back * Speed);

		}

		if (Input.GetKey(KeyCode.A))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.left * Speed);
		}



		if (Input.GetKey(KeyCode.D))
		{
			GetComponent<Rigidbody>().AddForce(Vector3.right * Speed);
		}
	
	}
}
