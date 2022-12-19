using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileAddon : MonoBehaviour
{
    [SerializeField]
    public float timeRemaining;
    public int damage;
    private Rigidbody rb;
    private bool targetHit;

    private void Start(){
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision) {
        // only stick to target you hit
        if(targetHit){
            return;
        }else{
            targetHit = true;
        }
        
        if(collision.gameObject.GetComponent<BasicEnemy>() !=null){
            BasicEnemy enemy = collision.gameObject.GetComponent<BasicEnemy>();
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
        // make stick
        //rb.isKinematic = true;
        //transform.SetParent(collision.transform);
    }
    void Update(){
        if(timeRemaining <= 0){
            Destroy(gameObject);
        }else{
            timeRemaining -= Time.deltaTime;
            Debug.Log(timeRemaining);
        }
    }
}
