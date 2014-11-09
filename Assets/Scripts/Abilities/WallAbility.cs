using UnityEngine;
using System.Collections;

public class WallAbility : MonoBehaviour 
{

    public GameObject wall;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {

            if (transform.forward.x == 1)
            {
                GameObject new_wall = (GameObject)Instantiate(wall, gameObject.transform.position + 
                    gameObject.transform.forward + new Vector3(1.5f, -2, 1.0f), Quaternion.identity);
            }

            if (transform.forward.x == -1)
            {

                GameObject new_wall = (GameObject)Instantiate(wall, gameObject.transform.position +
                   gameObject.transform.forward + new Vector3(-1.5f, -2, 1.0f), Quaternion.identity);

            }

        }
	
	}
}
