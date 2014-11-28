using UnityEngine;
using System.Collections;

public class CharSelection : MonoBehaviour {

	public UIButton ninjaButton1;
	public UIButton wallmanButton1;
	public UIButton gunmanButton1;
	public UIButton gamblerButton1;

	public UIButton ninjaButton2;
	public UIButton wallmanButto2;
	public UIButton gunmanButton2;
	public UIButton gamblerButton2;

	public bool p1_ninja;
	public bool p1_wallman;
	public bool P1_gunman;
	public bool p1_gambler;

	public bool p2_ninja;
	public bool p2_wallman;
	public bool p2_gunman;
	public bool p2_gambler;


	public void p1_ninjaSelcted()
	{

		{
			p1_ninja = true;
			p1_wallman = false;
			P1_gunman = false;
			p1_gambler = false;

		}
	}
	public void p1_wallmanSelcted()
	{
		
		{
			p1_ninja = false;
			p1_wallman = true;
			P1_gunman = false;
			p1_gambler = false;
		}
	}
	public void p1_gunmanSelcted()
	{
		
		{
			p1_ninja = false;
			p1_wallman = false;
			P1_gunman = true;
			p1_gambler = false;
		}
	}
	public void p1_gamblerSelcted()
	{
		
		{
			p1_ninja = false;
			p1_wallman = false;
			P1_gunman = false;
			p1_gambler = true;
		}
	}

	public void p2_ninjaSelcted()
	{
		
		{
			p2_ninja = true;
			p2_wallman = false;
			p2_gunman = false;
			p2_gambler = false;
		}
	}
	public void p2_wallmanSelcted()
	{
		
		{
			p2_ninja = false;
			p2_wallman = true;
			p2_gunman = false;
			p2_gambler = false;
		}
	}
	public void p2_gunmanSelcted()
	{
		
		{
			p2_ninja = false;
			p2_wallman = false;
			p2_gunman = true;
			p2_gambler = false;
		}
	}
	public void p2_gamblerSelcted()
	{
		
		{
			p2_ninja = false;
			p2_wallman = false;
			p2_gunman = false;
			p2_gambler = true;
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
