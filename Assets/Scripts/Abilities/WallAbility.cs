using UnityEngine;
using System.Collections;

public class WallAbility : MonoBehaviour 
{

    public GameObject wall;

    public GameObject groundCheck;

    public float wallCoolDown = 0.0f;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (Input.GetKeyDown(KeyCode.Q))
        {

            if (wallCoolDown <= 0)
            {
                wallCoolDown = 5.0f;

                if (transform.forward.x > 0)
                {

                    Vector3 spawnPosition = gameObject.transform.position +
                    gameObject.transform.forward + new Vector3(1.5f, groundCheck.transform.position.y, 1.5f);

                    GameObject new_wall = (GameObject)Instantiate(wall, spawnPosition, Quaternion.identity);

                }

                if (transform.forward.x < 0)
                {

                    Vector3 spawnPosition = gameObject.transform.position +
                    gameObject.transform.forward + new Vector3(-1.5f, groundCheck.transform.position.y, 1.5f);

                    GameObject new_wall = (GameObject)Instantiate(wall, spawnPosition, Quaternion.identity);


                }

            }

        }

        if (wallCoolDown > 0)
        {

            wallCoolDown -= Time.deltaTime;

            //Debug.Log(wallCoolDown);

        }
	
	}
}
