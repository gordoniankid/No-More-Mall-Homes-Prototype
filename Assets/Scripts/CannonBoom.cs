using UnityEngine;
using System.Collections;

public class CannonBoom : MonoBehaviour {
	public GameObject projBluePrint;
	public Transform projOrigin;
	Quaternion newRotation;
	public GameObject cannon;
	public GameObject cannon2;
	public float projForce =300f;
	bool doRotate;
	float rotPct;
	public int whichButton;

	// Use this for initialization
	void Start () {
		doRotate = false;
		rotPct = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		Ray ourRay = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit rayHit = new RaycastHit ();

		if (Physics.Raycast (ourRay, out rayHit, 1000f) && Input.GetMouseButtonDown(0)) {
			Debug.Log ("hitting I guess");
			newRotation = Quaternion.LookRotation (rayHit.point - cannon.transform.position);
			doRotate = true;
			rotPct = 0f;
			//cannon.transform.rotation = newRotation;

		} else {
			Debug.Log ("not hitting/not clicking");
		}

		if (doRotate) {
			float rotSpeed = Time.deltaTime;
			rotPct += rotSpeed;
			Debug.Log ("Barrel rotated by..." + rotPct * 100f + "%");
			if (rotPct < 1f) {
				cannon.transform.rotation = Quaternion.Slerp (cannon.transform.rotation, newRotation, 0.1f);	

			} else {
				GameObject newProj = Instantiate (projBluePrint, projOrigin.transform.position, projOrigin.rotation) as GameObject;
				newProj.GetComponent<Rigidbody> ().AddForce (projOrigin.forward * projForce);
				doRotate = false;
				StartCoroutine(ShakeScreen.Shake(0.25f,0.5f));
			}


		}
	}
}
