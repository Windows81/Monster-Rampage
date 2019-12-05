using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public Transform cameraPos, bckdrpPos;
	int posIndex = 0;
	public Vector2 position { get; set; } = new Vector2();

	void Update() {
		bckdrpPos.position = (cameraPos.position = position) / 2 + Vector3.forward * 3;
	}
}
