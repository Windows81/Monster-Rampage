using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterScript : MonoBehaviour {
	protected Rigidbody2D rigidBody;
	protected Collider2D tileCollider;
	protected void Start() {
		rigidBody = this.GetComponent<Rigidbody2D>();
		tileCollider = GameObject.Find("Tilemap").GetComponent<Collider2D>();
	}
}
