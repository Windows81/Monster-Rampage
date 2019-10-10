using System.Collections;
using System.Collections.Generic;
using static UnityEngine.Input;
using UnityEngine;

public class CharacterScript : MonoBehaviour {
	// Start is called before the first frame update
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		var horizD =
		(GetKey(KeyCode.RightArrow) ? 1 : 0) -
		(GetKey(KeyCode.LeftArrow) ? 1 : 0);
		print(horizD);
		GetComponent<Rigidbody2D>().velocity = new Vector2(horizD, 0);
	}
}
