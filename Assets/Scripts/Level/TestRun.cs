using UnityEngine;
using System.Collections;

public class TestRun : MonoBehaviour
{
		public LayerMask groundLayer;
		public GameObject groundObj;
		private bool grounded;
		Animator anim;
		bool facingRight;
		// Use this for initialization
		void Start ()
		{
				anim = GetComponent<Animator> ();
				facingRight = true;
		}
		void FixedUpdate ()
		{
				RaycastHit hitInfo;
				grounded = Physics.Raycast (groundObj.transform.position, Vector3.down, .2f, groundLayer);
				anim.SetBool ("Grounded", grounded);
				Debug.DrawLine (groundObj.transform.position, Vector3.down, Color.green);
       

		}
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.Space)) {
						
						
						if (grounded) {
								anim.SetBool ("Jump", true);
								Vector3 jumpvel = rigidbody.velocity;
								jumpvel.y = 0;
								rigidbody.velocity = jumpvel;
								rigidbody.AddForce (new Vector3 (0, 500f, 0));
						} 
            
				} else {
						anim.SetBool ("Jump", false);
				}
				if (Input.GetAxis ("Horizontal") > 0 && grounded) {
						if (!facingRight) {
								facingRight = true;
								Flip ();
                
						}
           
						anim.SetBool ("isMoving", true);
						float hAxis = Input.GetAxis ("Horizontal");
						anim.SetFloat ("Speed", hAxis);
						rigidbody.velocity = new Vector3 (hAxis * Time.deltaTime * 500f, 0, 0);
        
				} else if (Input.GetAxis ("Horizontal") < 0 && grounded) {
						if (facingRight) {
								facingRight = false;
								Flip ();
                
						}
						anim.SetBool ("isMoving", true);
						float hAxis = Input.GetAxis ("Horizontal");
						anim.SetFloat ("Speed", hAxis);
						rigidbody.velocity = new Vector3 (hAxis * Time.deltaTime * 500f, 0, 0);

				} else {
						anim.SetBool ("isMoving", false);
						anim.SetFloat ("Speed", 0);
				}
	
		}

		void Flip ()
		{
        
				Quaternion rot = transform.rotation;

                rot = Quaternion.Inverse(rot);
              
                transform.rotation = rot;
           
        
        
		}
}
