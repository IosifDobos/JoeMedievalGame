﻿using UnityEngine;

public class WeaponAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Hit"))
        {
            GetComponent<Animation>().Play("attackAnim");
        }
	}
}
