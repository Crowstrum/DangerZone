using UnityEngine;
using System.Collections;

public class ItemDeflection : MonoBehaviour 
{

    public float deflection = 1000.0f;

	// Use this for initialization
	void Start ()
    {

        

	}
	
	// Update is called once per frame
	void Update () 
    {
	


	}

    void OnTriggerEnter(Collider item)
    {
        if (item.gameObject.tag == "ThrownItem")
        {

            if (transform.parent.GetComponent<Invisibility>().invisible == true)
            {
                Vector3 itemPosition = item.gameObject.transform.position;

                Vector3 playerPosition = gameObject.transform.position;

                Vector3 itemDistance = itemPosition - playerPosition;

                itemDistance.Normalize();

                item.rigidbody.AddForce(itemDistance * deflection);

            }

        }


    }

}
