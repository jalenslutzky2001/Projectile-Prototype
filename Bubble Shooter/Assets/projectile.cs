using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.forward * speed * Time.deltaTime;

    }

    void OnCollisionEnter(Collision col){
        if (col.gameObject.tag == "Bubble"){
            // a rigidbody tagged as "Ball" hit the player
            Debug.Log("Hit");
        }
 }
}
