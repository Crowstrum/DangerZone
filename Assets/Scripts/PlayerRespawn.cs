using UnityEngine;
using System.Collections;

public class PlayerRespawn : MonoBehaviour 
{


	Vector3 playerOneRespawnPosition;

	Vector3 playerTwoRespawnPosition;
	
	public GameObject playerOneRespawnPoint;

	public GameObject playerTwoSpawnPoint;

	// Use this for initialization
	void Start () 
	{
		
		playerOneRespawnPosition = playerOneRespawnPoint.transform.position;

		//playerTwoRespawnPosition = playerTwoSpawnPoint.transform.position;

		
	}
	
	// Update is called once per frame
	void Update ()
	{

		if(Input.GetKeyDown(KeyCode.Tab))
		{
		
			gameObject.transform.position = playerOneRespawnPosition;

		}

		if (Input.GetKeyDown (KeyCode.T)) 
		{

			gameObject.transform.position = playerTwoRespawnPosition;

		}
		
	}
}
