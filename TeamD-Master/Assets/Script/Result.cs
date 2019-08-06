using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result : MonoBehaviour {

    //public void JumpSence()
    //{
    //    Application.LoadLevel("Title");
    //}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Return))
        {
            Application.LoadLevel("Title");
        }

    }
}
