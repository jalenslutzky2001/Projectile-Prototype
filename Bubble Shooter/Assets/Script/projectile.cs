using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed = 8f;
    public GameObject bubble;
    public GameObject enemy;
    

    void Start()
    {
        
    }
    
    void Update()
    {
        bubble.transform.position -= bubble.transform.forward * speed * Time.deltaTime;
        
    }

    //float code
    public void OnTriggerEnter(Collider other) {
        speed = 0;
        bubble.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        transform.localScale = new Vector3(4f, 4f, 4f);
        
    }
}
