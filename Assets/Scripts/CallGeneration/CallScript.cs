﻿using UnityEngine;
using System.Collections;
[System.Serializable]
public abstract class CallScript {
	virtual public string getNextDialog() {
		return "DEFUALT";
	}
}
