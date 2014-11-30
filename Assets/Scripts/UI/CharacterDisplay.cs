using UnityEngine;
using System.Collections;

public class CharacterDisplay : MonoBehaviour {

	public static CharacterDisplay Instance;



	void Awake()
	{
		Instance = this;
	}

	public int p1_SelectedChar;
	public int p2_SelectedChar;

	public Sprite char1;
	public Sprite char2;
	public Sprite char3;
	public Sprite char4;
	

//	public Sprite item0;
//	public Sprite item1;
//	public Sprite item2;
//	public Sprite item3;
//	public Sprite item4;


	public GameObject leftCharDisplayPort;
	public GameObject rightCharDisplayPort;

	UI2DSprite LeftCharPic;
	UI2DSprite RightCharPic;


//	GameObject p1_CurrentItem;
//	GameObject p2_CurrentItem;



	void Start () {

		LeftCharPic = leftCharDisplayPort.GetComponent<UI2DSprite> ();
		RightCharPic = rightCharDisplayPort.GetComponent<UI2DSprite>(); 

		p1_SelectedChar = CharSelection.p1Char;
		p2_SelectedChar = CharSelection.p2Char;

		if (p1_SelectedChar == 1) 
			{
		
			LeftCharPic.sprite2D = char1;
			}
		if (p1_SelectedChar == 2) 
			{
		
				LeftCharPic.sprite2D = char2;
			}

		if (p1_SelectedChar == 3) 
			{

			LeftCharPic.sprite2D = char3;
			}
		if (p1_SelectedChar == 4) 
			{
		
			LeftCharPic.sprite2D = char4;
			}

	
		if (p2_SelectedChar == 1) 
		{

			RightCharPic.sprite2D = char1;
		}
		if (p2_SelectedChar == 2) 
		{

			RightCharPic.sprite2D = char2;
		}
		
		if (p2_SelectedChar == 3) 
		{

			RightCharPic.sprite2D = char3;
		}
		if (p2_SelectedChar == 4) 
		{

			RightCharPic.sprite2D = char4;
		}


//			if(p2_SelectedChar == 1)
//				RightCharPic.sprite2D = char1;
//			if(p2_SelectedChar == 2)
//				RightCharPic.sprite2D = char2;
//			if(p2_SelectedChar == 3)
//				RightCharPic.sprite2D = char3;
//			if(p2_SelectedChar == 4)
//				RightCharPic.sprite2D = char4;
			
	}
	

	void Update () {


		if (Input.GetKeyDown (KeyCode.Space))
		{
			Instance.LeftCharPic.sprite2D = char2;
		}
		if (Input.GetKeyDown (KeyCode.A)) 
		{
			Instance.RightCharPic.sprite2D = char1;
		}
		if (Input.GetKeyDown (KeyCode.S)) 
		{
			Instance.LeftCharPic.sprite2D = char3;
		}
		if (Input.GetKeyDown (KeyCode.D)) 
		{
			Instance.LeftCharPic.sprite2D = char4;
		}
		
	}
}
