using UnityEngine;
using System.Collections;

public class WallAbility : MonoBehaviour 
{

    public float wallSpawnPoint = 1.63541f;

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

            if (transform.forward.x > 0)
            {

                Vector3 spawnPosition = gameObject.transform.position +
                    gameObject.transform.forward + new Vector3(1.5f, -3.7f, 1.0f);

                spawnPosition.y = wallSpawnPoint;

                GameObject new_wall = (GameObject)Instantiate(wall, spawnPosition, Quaternion.identity);
            }

            if (transform.forward.x < 0)
            {

                Vector3 spawnPosition = gameObject.transform.position +
                  gameObject.transform.forward + new Vector3(-1.5f, -3.7f, 1.0f);

                spawnPosition.y = wallSpawnPoint;

                GameObject new_wall = (GameObject)Instantiate(wall, spawnPosition, Quaternion.identity);

            }

        }
	
	}
}
