using UnityEngine;
using System.Collections;
using Sfs2X;

public class PlayerController : MonoBehaviour {
	
	public float forwardSpeed = 10;
	public float backwardSpeed = 8;
	public float rotationSpeed = 40;

	//flag that indicates if chuen reach the jade
	public bool atEnd = false;
	
	// Dirty flag for checking if movement was made or not
	public bool MovementDirty {get; set;}

	void Start() {
		MovementDirty = false;
	}

	void OnTriggerEntered(Collider other){
		if (other.gameObject.tag == "endPoint") {
			other.gameObject.SetActive(false);	
			atEnd=true;
		}
	}

	void Update () {
		// Forward/backward makes player model move
		float translation = Input.acceleration.x;
		translation = Input.GetAxis("Vertical");
		if (translation != 0) {
			this.transform.Translate(0, 0, translation * Time.deltaTime * forwardSpeed);
			MovementDirty = true;
		}
	
		// Left/right makes player model rotate around own axis
		float rotation = Input.acceleration.y;
		rotation = Input.GetAxis("Horizontal");
		if (rotation != 0) {
			this.transform.Rotate(Vector3.up, rotation * Time.deltaTime * rotationSpeed);
			MovementDirty = true;
		}
	}
}
