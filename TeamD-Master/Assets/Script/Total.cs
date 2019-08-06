using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Total : MonoBehaviour {
    public Text text;
	// Use this for initialization
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "合計金額:" + (score.Score * 810) + "円";
	}
}
