using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public GameObject GenerateObj;
    public float WaitTime = 0.0f;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(generate());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator generate()
    {
        while (true)
        {
            if (Random.Range(0, 5) == 0)
            {
                GameObject.Instantiate(GenerateObj, transform.position, transform.rotation);
            }
            yield return new WaitForSeconds(WaitTime);
        }
    }
}
