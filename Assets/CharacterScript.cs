using System.Collections;
using System.Collections.Generic;
using static UnityEngine.Input;
using UnityEngine;

public class CharacterScript : MonoBehaviour {
	public Rigidbody2D rigidBody;
	Collider2D tileCollider;
	CameraScript cameraScript;
	void Start() {
		tileCollider = GameObject.Find("Tilemap").GetComponent<Collider2D>();
		cameraScript = GameObject.Find("Main Camera").GetComponent<CameraScript>();
	}

	// Update is called once per frame
	void Update() {
		var horizD =
		(GetKey(KeyCode.RightArrow) || GetKey(KeyCode.D) ? 1 : 0) -
		(GetKey(KeyCode.LeftArrow) || GetKey(KeyCode.A) ? 1 : 0);

		var vertD = rigidBody.IsTouching(tileCollider) && (
			GetKeyDown(KeyCode.UpArrow) ||
			GetKeyDown(KeyCode.Space) ||
			GetKeyDown(KeyCode.D)) ? 12.7f : 0;

		rigidBody.AddForce(new Vector2(0, vertD), ForceMode2D.Impulse);
		rigidBody.AddForce(new Vector2(horizD, vertD));
		cameraScript[0] = rigidBody.position;
	}
}
