using UnityEngine;
using System.Collections;

public class Invisibility : MonoBehaviour {


    public float invisibilityCoolDown = 0.0f;

    public float invisibilityTimer = 0.0f;

    bool invisible = false;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (Input.GetKeyDown(KeyCode.E))
        {

            if (invisibilityCoolDown <= 0)
            {

                invisibilityCoolDown = 5.0f;

                gameObject.GetComponent<CapsuleCollider>().enabled = false;

                gameObject.GetComponentInChildren<SkinnedMeshRenderer>().enabled = false;

                invisible = true;
            }

        }

        if (invisible == true)
        {

            invisibilityTimer -= Time.deltaTime;

        }

        if (invisibilityTimer <= 0)
        {

            gameObject.GetComponent<CapsuleCollider>().enabled = true;

            gameObject.GetComponentInChildren<SkinnedMeshRenderer>().enabled = true;

            invisible = false;

            invisibilityTimer = 3.0f;

        }


        if (invisibilityCoolDown > 0)
        {

            invisibilityCoolDown -= Time.deltaTime;

            Debug.Log(invisibilityCoolDown);

        }

	}
}
