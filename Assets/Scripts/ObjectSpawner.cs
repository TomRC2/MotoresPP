using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject objectPrefab;
    public float bulletForce;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        { 

         GameObject bulletClone = Instantiate(objectPrefab, transform.position, transform.rotation);

         Rigidbody bulletRigidBody  = bulletClone.GetComponent<Rigidbody>();

         bulletRigidBody.velocity = transform.up * bulletForce;

            Destroy(bulletClone, 2f);
           
        } 
    }
}
