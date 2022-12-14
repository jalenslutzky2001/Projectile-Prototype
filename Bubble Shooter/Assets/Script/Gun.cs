using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    
    public GameObject bulletPrefab;
    public Transform m_SpawnTransform;
    public AudioSource sound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            GameObject bulletObject = Instantiate (bulletPrefab, m_SpawnTransform.position, m_SpawnTransform.rotation);
            bulletObject.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            GetComponent<AudioSource>().Play();
        }
    }
}
