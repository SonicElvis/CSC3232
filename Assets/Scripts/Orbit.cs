using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    [SerializeField]
    float speed = 100f;
    [SerializeField]
    GameObject sun;
    enum Axis {
        back,
        down,
        forward,
        left,
        right,
        up
    }
    [SerializeField]
    Axis axisType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // var sun = GameObject.Find("CentralOrb");
        switch(axisType){
            case Axis.back:this.transform.RotateAround(sun.transform.position, Vector3.back, speed * Time.deltaTime);          break;
            case Axis.down:this.transform.RotateAround(sun.transform.position, Vector3.down, speed * Time.deltaTime);          break;
            case Axis.forward:this.transform.RotateAround(sun.transform.position, Vector3.forward, speed * Time.deltaTime);    break;
            case Axis.left:this.transform.RotateAround(sun.transform.position, Vector3.left, speed * Time.deltaTime);          break;
            case Axis.right:this.transform.RotateAround(sun.transform.position, Vector3.right, speed * Time.deltaTime);        break;
            case Axis.up:this.transform.RotateAround(sun.transform.position, Vector3.up, speed * Time.deltaTime);              break;

        }
    }
}
