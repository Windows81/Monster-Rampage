using System.Collections;
using System.Collections.Generic;
using static UnityEngine.Input;
using UnityEngine;
using UnityEngine.UI;

public class Protagonist : CharacterScript {
	protected CameraScript cameraScript;




    public override void Start() {
		base.Start();
		cameraScript = GameObject.Find("Main Camera").GetComponent<CameraScript>();
	}
	void FixedUpdate() {
        
    var horizD =
		(GetKey(KeyCode.RightArrow) || GetKey(KeyCode.D) ? 1 : 0) -
		(GetKey(KeyCode.LeftArrow) || GetKey(KeyCode.A) ? 1 : 0);

		var vertD = rigidBody.IsTouching(tileCollider) && (
			GetKeyDown(KeyCode.UpArrow) ||
			GetKeyDown(KeyCode.Space) ||
			GetKeyDown(KeyCode.D)) ? 12.7f : 0;

		rigidBody.AddForce(new Vector2(0, vertD), ForceMode2D.Impulse);
		rigidBody.velocity = new Vector2(horizD * 7, rigidBody.velocity.y);
		cameraScript[0] = rigidBody.position;




     



    }


}