using UnityEngine;
using System.Collections;

public class CharacterDisplay : MonoBehaviour {

	public int p1_SelectedChar;
	public int p2_SelectedChar;

//	public UI2DSprite LeftCharPicPlace;
//	public UI2DSprite RightCharPicPlace;
//	public UI2DSprite LeftItemPicPlace;
//	public UI2DSprite RightItemPicPlace;

	public Sprite char1;
	public Sprite char2;
	public Sprite char3;
	public Sprite char4;

//	public Sprite item0;
//	public Sprite item1;
//	public Sprite item2;
//	public Sprite item3;
//	public Sprite item4;

	private UI2DSprite LeftCharPic;
	private UI2DSprite RightCharPic;
//	private UI2DSprite LeftCharItem;
//	private UI2DSprite RightCharItem;

//	GameObject p1_CurrentItem;
//	GameObject p2_CurrentItem;


	void Start () {
		LeftCharPic = GetComponent<UI2DSprite>(); 
		RightCharPic = GetComponent<UI2DSprite>(); 

//		LeftCharItem = GetComponent<UI2DSprite>(); 
//		RightCharItem = GetComponent<UI2DSprite>(); 
//
//		if(CharSelection.p1Char == 1)
//			LeftCharPic.sprite2D = char1;
//		if(CharSelection.p1Char == 2)
//			LeftCharPic.sprite2D = char2;
//		if(CharSelection.p1Char == 3)
//			LeftCharPic.sprite2D = char3;
//		if(CharSelection.p1Char == 4)
//			LeftCharPic.sprite2D = char4;
//
//		if(CharSelection.p2Char == 1)
//			RightCharPic.sprite2D = char1;
//		if(CharSelection.p2Char == 2)
//			RightCharPic.sprite2D = char2;
//		if(CharSelection.p2Char == 3)
//			RightCharPic.sprite2D = char3;
//		if(CharSelection.p2Char == 4)
//			RightCharPic.sprite2D = char4;



//		LeftCharPicPlace = LeftCharPic;
//		RightCharPicPlace = RightCharPic;
//
//		LeftCharItem.sprite2D = item0;
//		RightCharItem.sprite2D = item0;

		if(p1_SelectedChar == 1)
			LeftCharPic.sprite2D = char1;
		if(p1_SelectedChar == 2)
			LeftCharPic.sprite2D = char2;
		if(p1_SelectedChar == 3)
			LeftCharPic.sprite2D = char3;
		if(p1_SelectedChar == 4)
			LeftCharPic.sprite2D = char4;
	}
	

	void Update () {


		if (Input.GetKeyDown (KeyCode.Space))
		{
			LeftCharPic.sprite2D = char2;
		}
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			LeftCharPic.sprite2D = char1;
		}
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			LeftCharPic.sprite2D = char3;
		}
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			LeftCharPic.sprite2D = char4;
		}
		
	}
}
