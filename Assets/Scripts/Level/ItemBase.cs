using UnityEngine;
using System.Collections;

public abstract class ItemBase : MonoBehaviour {

    public UI2DSprite itemSprite;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public ItemBase()
    {
        itemSprite = null;
    }

    public UI2DSprite getSprite()
    {
        return itemSprite;
    }

    public void setSprite(UI2DSprite newSprite)
    {
        itemSprite = newSprite;
    }

    public virtual void onThrow()
    {
        
    }

    public virtual void onHit()
    {
        
    }
}
