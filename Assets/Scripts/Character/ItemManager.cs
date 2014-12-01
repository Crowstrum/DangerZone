using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

	public GameObject itemHeld;
	public GameObject player;
	public GameObject itemThrown;
	public GameObject pHand;

    public GameObject rayStart;

	private Vector3 temp;
	public Vector3 cPlayerInput;

	public TestRun movement;

	public bool throwItem;

	private float angle;

    private ItemBase itemScript;

    private RaycastHit rayHitInfo;

	// Use this for initialization
	void Start ()
    {
		itemHeld = null;
		player = this.gameObject.transform.parent.gameObject;

		throwItem = false;

		movement = GetComponentInParent<TestRun> ();
	
	}
	
	// Update is called once per frame
	void Update () 
    {

		if (itemHeld != null) {
			
			itemHeld.transform.position = pHand.transform.position;
		}

        GetAiming();

        foreach (Collider col in Physics.OverlapSphere(transform.position, 1.25f))
        {
            if (col.tag == "Item" || col.tag == "ThrownItem")
            {
                Debug.DrawRay(rayStart.transform.position, col.transform.position - rayStart.transform.position);
            }
        }

		if (itemHeld == null && (Input.GetButtonDown (player.name + "B") || Input.GetKeyDown (KeyCode.E)))
        {
			Debug.Log(player.name + "B button Pressed");

			foreach(Collider col in Physics.OverlapSphere(transform.position, 1.5f))
            {
				if(col.tag == "Item" || col.tag == "ThrownItem")
                {
                    //Debug.DrawRay(transform.position, col.transform.position - rayStart.transform.position);
                    if (itemHeld == null && Physics.Raycast(new Ray(rayStart.transform.position, col.transform.position - rayStart.transform.position), out rayHitInfo, 1.25f))
                    {
                        if(rayHitInfo.collider.tag != "Player")
                        itemCatch(col.gameObject);
                    }
				}
			}
		}

		if (itemHeld != null && (Input.GetButtonDown (player.name + "X") || Input.GetKeyDown (KeyCode.F))) 
        {
			Debug.Log(player.name + "X button pressed");

			throwItem = true;
		}
	}

	void FixedUpdate() {

		if (itemHeld != null && throwItem == true) 
        {

			Debug.Log(player.name + "item thrown");

            temp = 25.0f * cPlayerInput;

            throwItem = false;
            itemThrown = Instantiate(itemHeld, itemHeld.transform.position, itemHeld.transform.rotation) as GameObject;
            itemThrown.tag = "ThrownItem";
            itemThrown.rigidbody.useGravity = true;
            itemThrown.collider.enabled = true;
            itemThrown.rigidbody.AddForce(temp + player.rigidbody.velocity, ForceMode.Impulse);
            Destroy(itemHeld);
            itemHeld = null;
		}

	}

	void itemCatch(GameObject item)
    {
		itemHeld = item;
		itemHeld.collider.enabled = false;
		itemHeld.rigidbody.velocity = Vector3.zero;
		itemHeld.rigidbody.useGravity = false;
        itemHeld.tag = "Item";
		
        if (player.name == "Player1")
			itemHeld.layer = 10;
		else if (player.name == "Player2")
			itemHeld.layer = 11;
	}

    void GetAiming()
    {
        cPlayerInput = new Vector3(Input.GetAxis(player.name + "RightStickX"), Input.GetAxis(player.name + "RightStickY"), 0.0f);

        angle = Mathf.Atan2(Input.GetAxis(player.name + "RightStickX"), Input.GetAxis(player.name + "RightStickY")) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0.0f, 0.0f, angle);

        Debug.DrawRay(transform.position, cPlayerInput, Color.cyan);
    }
}
