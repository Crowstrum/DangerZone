﻿using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public Vector3 velocity;

    public float deflection;

  

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        transform.position += velocity * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.R))
        {

         
            Collider[] hitColliders = Physics.OverlapSphere(gameObject.transform.position, 5.0f);

            Debug.Log(hitColliders[0].transform.tag);

            foreach( Collider col in hitColliders)
            {
                if (col.tag == "Item" || col.tag == "Player")
                {
                    Vector3 distance = col.transform.position - gameObject.transform.position;

                    distance.Normalize();

                    col.rigidbody.AddForce(distance * deflection);
                    
                    Destroy(gameObject);

                }
                
                else 
                {
                    
                    Destroy(gameObject);

                }

            }

        }

	}


}