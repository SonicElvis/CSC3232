using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerfollow : MonoBehaviour
{
    [SerializeField]
    int range;
    [SerializeField]
    public Transform Playerpos;
    [SerializeField]
    public Transform Agentpos;
    [SerializeField]
    GameObject SpotLight;
    AudioSource soundByte;
    public PlayerMovement pM;
    bool play;
    UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
       agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
       soundByte = GetComponent<AudioSource>();
    }
    void Update()
    {   
          agent.destination = Playerpos.position;    
          if (pM.touched){
            GetComponent<UnityEngine.AI.NavMeshAgent>().speed = 30;
            GetComponent<UnityEngine.AI.NavMeshAgent>().stoppingDistance = 10;
          }

          if(Vector3.Distance(Agentpos.position, Playerpos.position) < range){
            Debug.Log("GOT YA BITCH");
            SpotLight.GetComponent<LightFollow>().enabled = true;
            if (!soundByte.isPlaying){
              soundByte.Play();
            }
          }else{
            SpotLight.GetComponent<LightFollow>().enabled = false;
            soundByte.Stop();
          }

          
        
    }
}
