using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeview : MonoBehaviour {
    public Text text;
    public int time2;
    // Use this for initialization
    void Start () {
        time.Time = 90;
        time2 = 60;
    }
	
	// Update is called once per frame
	void Update () {

        time2--;
        if (time2 < 0)
        {
            time.Time--;
            text.text = "時間:" + time.Time;
            if(time.Time < 0)
            {
                Application.LoadLevel("Result");
            }
            time2 = 60;
        }
    }
}
