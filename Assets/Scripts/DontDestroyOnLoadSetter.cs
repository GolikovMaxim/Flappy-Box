﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoadSetter : MonoBehaviour {
	private void Start() {
		DontDestroyOnLoad(gameObject);
	}
}
