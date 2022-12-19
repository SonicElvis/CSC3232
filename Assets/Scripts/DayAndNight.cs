using UnityEngine;

public class DayAndNight : MonoBehaviour
{
    Vector3 rot = Vector3.zero;
    [SerializeField]
    float degpersec = 6;
    // Update is called once per frame
    void Update()
    {
        rot.x=degpersec*Time.deltaTime;
        transform.Rotate(rot, Space.World);
    }
}
