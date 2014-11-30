using UnityEngine;
using System.Collections;

public class FlagRespawn : MonoBehaviour 
{


	Vector3 respawnPosition;

	public GameObject flagRespawnPoint;

	// Use this for initialization
	void Start () 
	{
	
		respawnPosition = flagRespawnPoint.transform.position;

	}
	
	// Update is called once per frame
	void Update ()
	{
	
		gameObject.transform.position = respawnPosition;

	}
}
