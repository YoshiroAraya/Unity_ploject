using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopBaggage : MonoBehaviour
{
    public int nCntBaggage = 0;
    public int nCntTimer = 0;




    public GameObject[] Baggage = new  GameObject[5];
    public void Lost(){
        nCntBaggage = 0;
        foreach(GameObject g in Baggage)
        {
            g.SetActive(false);
        }
        GetComponent<PlayerController>().speedRun = 30 - nCntBaggage * 4.5f;
    }
    void OnTriggerStay(Collider col)
    {
        if (nCntBaggage < Baggage.Length)
        {
            if (col.gameObject.tag == "Baggage")
            {
                nCntTimer++;

                Debug.Log("baggage");
                if (nCntTimer % 25 == 0)
                {

                    nCntBaggage++;

                    Baggage[nCntBaggage - 1].SetActive(true);
                    GetComponent<PlayerController>().speedRun = 30 - nCntBaggage * 4.5f;
                }

            }
        }
            
        if (col.gameObject.tag == "Track")
        {
            Debug.Log("baggage");
            if (nCntBaggage > 0)
            {
                nCntTimer++;
                if (nCntTimer % 15 == 0)
                {
                    nCntBaggage--;

                    Baggage[nCntBaggage].SetActive(false);
                    GetComponent<PlayerController>().speedRun = 30 - nCntBaggage * 4.5f;


                    score.Score += 1;
                }
            }
        }
    }
}