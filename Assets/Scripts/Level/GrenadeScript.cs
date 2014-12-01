﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GrenadeScript : ItemBase
{

    public float expForce;

    // Use this for initialization
    void Awake()
    {
        //expForce = 1000;
    }

    // Update is called once per frame
    IEnumerator Start()
    {

        while (true)
        {
            if (this.gameObject.tag == "ThrownItem")
            {
                //Debug.Log("If statement entered");
                yield return new WaitForSeconds(Random.Range(3.0f, 6.0f));
                //Debug.Log("Wait ended");
                onHit();
            }

            yield return new WaitForFixedUpdate();

            //Debug.Log("Coroutine passed");
        }

    }

    public override void onHit()
    {
        Debug.Log("OnHit called");

        //rigidbody.AddExplosionForce(expForce, transform.position, 5f);

        Collider[] hitcolliders = Physics.OverlapSphere(gameObject.transform.position, 4.5f);

        foreach (Collider col in hitcolliders)
        {
            if (col.gameObject != this.gameObject && col.tag == "Item" || col.tag == "ThrownItem" || col.tag == "Player")
            {
                //Debug.Log("item/player found");

                Vector3 distance = col.transform.position - gameObject.transform.position;
                //Vector3 distance = gameObject.transform.position - col.transform.position;

                distance.Normalize();

                //col.rigidbody.velocity = new Vector3(500.0f, 0.0f, 0.0f);
                //col.rigidbody.AddForce(distance * expForce);
                col.rigidbody.AddExplosionForce(expForce, transform.position, 5f);

                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }

        }
    }

}