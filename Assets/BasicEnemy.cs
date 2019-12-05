using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BasicEnemy : CharacterScript {
	public GameObject target;
	public float speed;
	public float attackRange;
	public int attackDamage;
	public float timeBetweenAttacks;
	bool flipped;

	public override void Start() => Rest();

	void FixedUpdate() => MoveToPlayer();
	bool LookAt() => flipped = target.GetComponent<SpriteRenderer>().flipX = target.transform.position.x > transform.position.x;

	public void MoveToPlayer() {
		LookAt();
		Debug.Log(target.transform.position.x - transform.position.x);

		//move towards player
		if (Vector3.Distance(transform.position, target.transform.position) < attackRange)
			transform.Translate(new Vector3((flipped ? -1 : 1) * speed * Time.deltaTime, 0, 0));
	}

	public void Rest() {

	}
}