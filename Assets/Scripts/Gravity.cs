using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField]
    GameObject prism;
    [SerializeField]
    public float timeRemaining = 10;
    // Update is called once per frame
    void Update()
    {
        if (timeRemaining <= 0) {
            prism.GetComponent<Rigidbody>().useGravity = true;
            prism.GetComponent<Rigidbody>().velocity = new Vector3(5,-15,5);
        }
        else {
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);
        }
    }
    //Hi future me 
}
