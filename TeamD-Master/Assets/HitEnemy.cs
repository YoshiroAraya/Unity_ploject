using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour
{

    GameObject refObj;
    public GameObject gameControllerObj;

    void Start()
    {
        refObj = GameObject.Find("Deliver");
        Debug.Log("Deliver");

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy");

            PlayerController pc = GetComponent<PlayerController>();
            pc.EnemyHit();
            GetComponent<PopBaggage>().Lost();
            Destroy(col.gameObject);
        }

       
    }
}
