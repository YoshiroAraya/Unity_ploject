using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trak : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider C)
    {
        if(C.transform.tag == "Player")
        {
            //Destroy(this.gameObject); //ぶつかったときに削除する
            
        }
    }
}
