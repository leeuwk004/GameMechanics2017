﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Won : MonoBehaviour {

	// Use this for initialization


	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			SceneManager.LoadScene("MainMenu");
			}
	}
}
