using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BasicEnemy : CharacterScript {
	public GameObject target;
	public float speed = 3f;
	public float attackRange = 1f;
	public int attackDamage = 1;
	public float timeBetweenAttacks;


	void Start() => Rest();

	void FixedUpdate() => MoveToPlayer();
	void LookAt() => target.GetComponent<SpriteRenderer>().flipX = target.transform.position.x > transform.position.x;

	public void MoveToPlayer() {
		LookAt();

		//move towards player
		if (Vector3.Distance(transform.position, target.transform.position) > attackRange) {
			transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
		}
	}

	public void Rest() {

	}
}