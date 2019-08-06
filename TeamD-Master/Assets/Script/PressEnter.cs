using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PressEnter : MonoBehaviour {

    private float nexTime;
    public float interval = 0.7f;   //点滅周期
    public Text text;

	// Use this for initialization
	void Start () {

        nexTime = Time.time;	
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Time.time > nexTime)
        {
            text.enabled = !text.enabled;

            nexTime += interval;
        }

	}
}
