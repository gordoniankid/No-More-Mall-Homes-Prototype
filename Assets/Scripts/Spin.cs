using UnityEngine;
using System.Collections;

public class Spin : MonoBehaviour
{
	public float speed = 10f;

	void Start() {




		}

	void Update ()
	{
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (0, 1, 0);

		}

		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (0, -1, 0);

		}


		//transform.Rotate(Vector3.up, speed * Time.deltaTime);
	}
}
