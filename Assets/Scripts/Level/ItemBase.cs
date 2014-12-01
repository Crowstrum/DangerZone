using UnityEngine;
using System.Collections;

public abstract class ItemBase : MonoBehaviour
{

		public UI2DSprite itemSprite;
		public Sprite text;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		public ItemBase ()
		{
				itemSprite = null;
		}

		public Sprite getSprite ()
		{
				return text;
		}

		public void setSprite (UI2DSprite newSprite)
		{
				itemSprite = newSprite;
		}

		
	
		public abstract void OnCollisionEnter (Collision col);
		public abstract void onHit ();

}
