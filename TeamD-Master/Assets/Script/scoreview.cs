using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreview : MonoBehaviour {
    public Text text;
	// Use this for initialization
	void Start () {
        score.Score = 0;

    }
	
	// Update is called once per frame
	void Update () {
        text.text = "積載数:" + score.Score;
	}
}
