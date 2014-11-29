using UnityEngine;
using System.Collections;

public class ItemManager : MonoBehaviour {

	public GameObject itemHeld;
	public GameObject player;
	private GameObject itemThrown;
	public GameObject pHand;

	private Vector3 temp;
	public Vector3 cPlayerInput;

	public TestRun movement;

	public bool throwItem;

	private float angle;

	// Use this for initialization
	void Start () {
		itemHeld = null;
		player = this.gameObject.transform.parent.gameObject;

		throwItem = false;

		movement = GetComponentInParent<TestRun> ();
	
	}
	
	// Update is called once per frame
	void Update () {

		if (itemHeld != null) {
			
			itemHeld.transform.position = pHand.transform.position;
		}

		if (player.rigidbody.velocity == Vector3.zero) {
			cPlayerInput = new Vector3 (Input.GetAxis (player.name + "RightStickX"), Input.GetAxis (player.name + "RightStickY"), 0.0f);

			angle = Mathf.Atan2 (Input.GetAxis (player.name + "RightStickX"), Input.GetAxis (player.name + "RightStickY")) * Mathf.Rad2Deg;
		
			transform.rotation = Quaternion.Euler (0.0f, 0.0f, angle);

		} else {
			cPlayerInput = transform.forward;

			//angle = Mathf.Atan2 (Input.GetAxis (player.name + "RightStickX"), Input.GetAxis (player.name + "RightStickY")) * Mathf.Rad2Deg;
			
			//transform.rotation = Quaternion.Euler (0.0f, 0.0f, angle);

		}

		Debug.DrawRay(transform.position, transform.right, Color.cyan);


		if (itemHeld == null && (Input.GetButtonDown (player.name + "B") || Input.GetKeyDown (KeyCode.E))) {

			Debug.Log("B button Pressed");

			foreach(Collider col in Physics.OverlapSphere(transform.position, 2.0f)){
				if(col.tag == "Item" || col.tag == "ThrownItem"){
					if(itemHeld == null){
						itemCatch(col.gameObject);
					}
					//Debug.Log ("item caught/picked up");
				}
			}
		}

		if (itemHeld != null && (Input.GetButtonDown (player.name + "X") || Input.GetKeyDown (KeyCode.F))) {
			Debug.Log("X button pressed");

			throwItem = true;
		}
	}

	void FixedUpdate() {

		if (itemHeld != null && throwItem == true) {

			Debug.Log("item thrown");

			temp = 25.0f * cPlayerInput;

			throwItem = false;
			itemThrown = Instantiate(itemHeld, transform.position, transform.rotation) as GameObject;
			Destroy(itemHeld);
			itemHeld = null;
			itemThrown.rigidbody.AddForce(temp + player.rigidbody.velocity, ForceMode.Impulse );
			itemThrown.tag = "ThrownItem";
		}

	}


	void itemPickup(){
	
	}

	void itemCatch(GameObject item){
		itemHeld = item;
		itemHeld.collider.enabled = false;
		itemHeld.rigidbody.velocity = Vector3.zero;
		itemHeld.rigidbody.useGravity = false;
		if (player.name == "Player1")
			itemHeld.layer = 10;
		else if (player.name == "Player2")
			itemHeld.layer = 11;
	}

}
