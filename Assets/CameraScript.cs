using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	public Transform cameraPos, bckdrpPos;
	int posIndex = 0;
	Vector2[] posList = new Vector2[5];
	public Vector2 this[int n] {
		get { return posList[n]; }
		set { posList[n] = value; }
	}
	void Start() {
	}

	void Update() {
		var v2 = posList[posIndex];
		bckdrpPos.position = (cameraPos.position = v2) / 2 + Vector3.forward * 3;
	}
}
