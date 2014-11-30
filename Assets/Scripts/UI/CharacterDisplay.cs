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
	public Sprite char1A;
	public Sprite char2A;
	public Sprite char3A;
	public Sprite char4A;
	
//	public Sprite item0;
//	public Sprite item1;
//	public Sprite item2;
//	public Sprite item3;
//	public Sprite item4;


	public GameObject leftCharDisplayPort;
	public GameObject rightCharDisplayPort;
	public GameObject leftItemDisplayPort;
	public GameObject rightItemDisplayPort;


	UI2DSprite LeftCharPic;
	UI2DSprite RightCharPic;
	UI2DSprite LeftItemPic;
	UI2DSprite RightItemPic;


//	GameObject p1_CurrentItem;
//	GameObject p2_CurrentItem;
//	public UI2DSprite p1_Item;
//	public UI2DSprite p2_Item;


//	void AbilityOnCoolDown(int inputInt)
//	{
//		float coolDownInSeconds = 25f;
//		float timeStamp = Time.time + coolDownInSeconds;
//
//		if(inputInt == 11)
//		{
//			// grays out pic
//			TweenPosition.Begin(leftItemDisplayPort, 1, 0);
//
//			//wait some seconds...
//			if(timeStamp <= Time.time)
//			//ability comes back on un-grey pic
//				TweenPosition.Begin(leftItemDisplayPort, 1, 1);
//		}
//	}

	void Start () {

		LeftCharPic = leftCharDisplayPort.GetComponent<UI2DSprite> ();
		RightCharPic = rightCharDisplayPort.GetComponent<UI2DSprite>(); 
		LeftItemPic = leftItemDisplayPort.GetComponent<UI2DSprite>();
		RightItemPic = rightItemDisplayPort.GetComponent<UI2DSprite>();

		p1_SelectedChar = CharSelection.p1Char;
		p2_SelectedChar = CharSelection.p2Char;

		if (p1_SelectedChar == 1) 
			{
			LeftItemPic.sprite2D = char1A;
			LeftCharPic.sprite2D = char1;
			}
		if (p1_SelectedChar == 2) 
			{
			LeftItemPic.sprite2D = char2A;
			LeftCharPic.sprite2D = char2;
			}

		if (p1_SelectedChar == 3) 
			{
			LeftItemPic.sprite2D = char3A;
			LeftCharPic.sprite2D = char3;
			}
		if (p1_SelectedChar == 4) 
			{
			LeftItemPic.sprite2D = char4A;
			LeftCharPic.sprite2D = char4;
			}

	
		if (p2_SelectedChar == 1) 
		{
			RightItemPic.sprite2D = char1A;
			RightCharPic.sprite2D = char1;
		}
		if (p2_SelectedChar == 2) 
		{
			RightItemPic.sprite2D = char2A;
			RightCharPic.sprite2D = char2;
		}
		
		if (p2_SelectedChar == 3) 
		{
			RightItemPic.sprite2D = char3A;
			RightCharPic.sprite2D = char3;
		}
		if (this.p2_SelectedChar == 4) 
		{
			RightItemPic.sprite2D = char4A;
			RightCharPic.sprite2D = char4;
		}

//		p1_Item = p1_CurrentItem.GetComponent<UI2DSprite>();
//		p2_Item = p2_CurrentItem.GetComponent<UI2DSprite>();
		
			
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
