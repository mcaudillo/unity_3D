using UnityEngine;
using System.Collections;
using Sfs2X;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Requests;
using Sfs2X.Logging;

public class PlayerController : MonoBehaviour {
	
	public float forwardSpeed = 10;
	public float backwardSpeed = 8;
	public float rotationSpeed = 40;
	public GUIText winText;

	//flag that indicates if chuen reach the jade
	public bool atEnd = false;
	
	//check if movement was made or not
	public bool MovementDirty {get; set;}

	void Start() {
		MovementDirty = false;
	}

	void OnTriggerEntered(Collider other){
		if (other.gameObject.tag == "endPoint") {
			other.gameObject.SetActive(false);	
			atEnd=true;
			winText.text="You win!";
		}
	}

	void Update () {
		// Forward/backward makes player model move with accelerometer axis x
		float translation = Input.acceleration.x;
		translation = Input.GetAxis("Vertical");
		if (translation != 0) {
			this.transform.Translate(0, 0, translation * Time.deltaTime * forwardSpeed);
			MovementDirty = true;
		}
	
		// Left/right makes player model rotate around own axis with accelerometer axis y
		float rotation = Input.acceleration.y;
		rotation = Input.GetAxis("Horizontal");
		if (rotation != 0) {
			this.transform.Rotate(Vector3.up, rotation * Time.deltaTime * rotationSpeed);
			MovementDirty = true;
		}
	}
}
