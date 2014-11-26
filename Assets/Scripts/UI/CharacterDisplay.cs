using UnityEngine;
using System.Collections;

public class CharacterDisplay : MonoBehaviour {

	public Sprite char1;
	public Sprite char2;
	private UI2DSprite spriteRenderer;

//	void CharSelected()
//	{
//		if (Input.GetButtonDown ("p"))
//						gameObject.GetComponents(SpriteRenderer) = char1;
//	
//	}


	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<UI2DSprite>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		//if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
		spriteRenderer.sprite2D = char1;
		//spriteRenderer.sprite = char1;

		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) // If the space bar is pushed down
		{
			spriteRenderer.sprite2D = char2;
		}
		if (Input.GetKeyDown (KeyCode.A)) // If the space bar is pushed down
		{
			spriteRenderer.sprite2D = char1;
		}
		
	}
	/*
	void ChangeTheDamnSprite ()
	{
		if (spriteRenderer.sprite == char1) // if the spriteRenderer sprite = sprite1 then change to sprite2
		{
			spriteRenderer.sprite = char2;
		}
		if(spriteRenderer.sprite = char2)
		{
			spriteRenderer.sprite = char1; // otherwise change it back to sprite1
		}
	}
	*/
}
