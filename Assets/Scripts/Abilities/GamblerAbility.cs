using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 
{

	float gamblerAbilityCoolDown;

	GameObject currentItem;

	// Use this for initialization
	void Start () 
	{
	
		currentItem = GetComponent<ItemManager>().itemHeld;

	}
	
	// Update is called once per frame
	void Update () 
	{
	
		if (Input.GetKeyDown (KeyCode.Y)) 
		{
			if(gamblerAbilityCoolDown <= 0)
			{

			currentItem = global.instance.getRandomItem;

			}
		}

		if (gamblerAbilityCoolDown > 0) 
		{

			gamblerAbilityCoolDown -= Time.deltaTime;

		}

	}
}
