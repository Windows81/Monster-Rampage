using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class LevelSwitch : MonoBehaviour {
	void Start() { }
	void Update() { }

	Task<bool> SetLevelTask = null;
	Task<bool> SetLevel(int lvl) {
		SetLevelTask = new Task<bool>(() => {
			return true;
		});
		SetLevelTask.Start();
		return SetLevelTask;
	}
}
