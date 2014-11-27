using UnityEngine;
using System.Collections;

public class GunAbility : MonoBehaviour 
{

    public float shootCoolDown = 0.0f;

    public GameObject bulletPrefab;

    public Vector3 bulletVelocity;

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (shootCoolDown <= 0)
            {

                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity) 
                    as GameObject;

                bullet.GetComponent<Bullet>().velocity = bulletVelocity;


            }

        }


	}
}
