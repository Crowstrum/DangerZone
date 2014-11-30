using UnityEngine;
using System.Collections;

public class CharSelection : MonoBehaviour {

	public static CharSelection InstanceS;
	void Awake()
	{
		InstanceS = this;
		}

	public UIButton ninjaButton1;
	public UIButton wallmanButton1;
	public UIButton gunmanButton1;
	public UIButton gamblerButton1;

	public UIButton ninjaButton2;
	public UIButton wallmanButton2;
	public UIButton gunmanButton2;
	public UIButton gamblerButton2;

	public bool p1_ninja;
	public bool p1_wallman;
	public bool p1_gunman;
	public bool p1_gambler;

	public bool p2_ninja;
	public bool p2_wallman;
	public bool p2_gunman;
	public bool p2_gambler;

	public static int p1Char;
	public static int p2Char;

	public void buttonColorOnSelect()
	{

			//P1 Buttons
			if(p1_ninja == true)
				ninjaButton1.defaultColor = Color.green;
			else
				ninjaButton1.ResetDefaultColor();

			if(p1_wallman == true)
				wallmanButton1.defaultColor = Color.green;
			else
				wallmanButton1.ResetDefaultColor();

			if(p1_gunman == true)
				gunmanButton1.defaultColor = Color.green;
			else
				gunmanButton1.ResetDefaultColor();
			if(p1_gambler == true)
				gamblerButton1.defaultColor = Color.green;
			else
				gamblerButton1.ResetDefaultColor();
		


			//P2 Buttons
			if(p2_ninja == true)
				ninjaButton2.defaultColor = Color.green;
			else
				ninjaButton2.ResetDefaultColor();
			
			if(p2_wallman == true)
				wallmanButton2.defaultColor = Color.green;
			else
				wallmanButton2.ResetDefaultColor();
			
			if(p2_gunman == true)
				gunmanButton2.defaultColor = Color.green;
			else
				gunmanButton2.ResetDefaultColor();
			if(p2_gambler == true)
				gamblerButton2.defaultColor = Color.green;
			else
				gamblerButton2.ResetDefaultColor();

		//setCharacter();
	}

	public void p1_ninjaSelcted()
	{
		{
			p1_ninja = true;
			p1_wallman = false;
			p1_gunman = false;
			p1_gambler = false;
			p1Char = 1;

		}
		buttonColorOnSelect();
	//	CharacterDisplay.Instance.characterDisplayPls (11);
	}
	public void p1_wallmanSelcted()
	{
		
		{
			p1_ninja = false;
			p1_wallman = true;
			p1_gunman = false;
			p1_gambler = false;
			p1Char = 2;
		}
		buttonColorOnSelect();
	//	CharacterDisplay.Instance.characterDisplayPls (12);
	}
	public void p1_gunmanSelcted()
	{
		
		{
			p1_ninja = false;
			p1_wallman = false;
			p1_gunman = true;
			p1_gambler = false;
			p1Char = 3;
		}
		buttonColorOnSelect();
	//	CharacterDisplay.Instance.characterDisplayPls (13);
	}
	public void p1_gamblerSelcted()
	{
		
		{
			p1_ninja = false;
			p1_wallman = false;
			p1_gunman = false;
			p1_gambler = true;
			p1Char = 4;
		}
		buttonColorOnSelect();
	//	CharacterDisplay.Instance.characterDisplayPls (14);
	}

	public void p2_ninjaSelcted()
	{
		{
			p2_ninja = true;
			p2_wallman = false;
			p2_gunman = false;
			p2_gambler = false;
			p2Char = 1;
		}
		buttonColorOnSelect();
	//	CharacterDisplay.Instance.characterDisplayPls (21);
	}
	public void p2_wallmanSelcted()
	{
		
		{
			p2_ninja = false;
			p2_wallman = true;
			p2_gunman = false;
			p2_gambler = false;
			p2Char = 2;
		}
		buttonColorOnSelect();
	//		CharacterDisplay.Instance.characterDisplayPls (22);
	}
	public void p2_gunmanSelcted()
	{
		
		{
			p2_ninja = false;
			p2_wallman = false;
			p2_gunman = true;
			p2_gambler = false;
			p2Char = 3;
		}
		buttonColorOnSelect();
	//		CharacterDisplay.Instance.characterDisplayPls (23);
	}
	public void p2_gamblerSelcted()
	{
		
		{
			p2_ninja = false;
			p2_wallman = false;
			p2_gunman = false;
			p2_gambler = true;
			p2Char = 4;
		}
		buttonColorOnSelect();
	//		CharacterDisplay.Instance.characterDisplayPls (24);
	}

	public void setCharacter()
	{

		//CharacterDisplay.p1_SelectedChar = CharSelection.p1Char;
		//CharacterDisplay.p2_SelectedChar = CharSelection.p2Char;

	}
}
