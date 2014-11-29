﻿using UnityEngine;
using System.Collections;

public class TestRun : MonoBehaviour
{
		public LayerMask groundLayer;
		public GameObject groundObj;
        public GameObject collisionCheck;
		public float movespeed = 100f;
		public float jumpForce = 100f;
		private bool grounded;
        private bool wallCollision;
        private float verticalSpeed;
		Animator anim;
		bool facingRight;
		// Use this for initialization
		void Start ()
		{
				anim = GetComponent<Animator> ();
				facingRight = true;
		}
		
		// Update is called once per frame
		void FixedUpdate ()
		{
            //Debug.Log(rigidbody.velocity.y);
           
            if (!grounded)
            {
                verticalSpeed = rigidbody.velocity.y;
                anim.SetFloat("VertSpeed", Mathf.Abs(verticalSpeed));
            }
            else if (grounded)
            {
                anim.SetFloat("VertSpeed", 0);
               
                
            }
				grounded = Physics.CheckSphere (groundObj.transform.position, .2f, groundLayer);
                wallCollision = Physics.CheckSphere(collisionCheck.transform.position, .5f, groundLayer);
				anim.SetBool ("Grounded", grounded);
				Debug.DrawLine (groundObj.transform.position, Vector3.down, Color.green);
				
				float hAxis = Input.GetAxis ("Horizontal");
                if (!wallCollision)
                {
                    anim.SetFloat("Speed", Mathf.Abs(hAxis));
                    rigidbody.velocity = new Vector3(hAxis * Time.deltaTime * movespeed, rigidbody.velocity.y, 0);
                }
				if (hAxis > 0 && !facingRight) {
						Flip ();
						facingRight = true;
				} else if (hAxis < 0 && facingRight) {
						Flip ();
						facingRight = false;
				}
				
						
		
		}
		
		void Update ()
		{
            
				if (grounded && (Input.GetKeyDown (KeyCode.Space) || Input.GetButtonDown("Player1A"))) {
			
								anim.SetBool ("Jump", true);
								rigidbody.velocity = new Vector3(0,jumpForce,0);
                }
                else
                {
                    anim.SetBool("Jump", false);
                }
		}

		void Flip ()
		{
        
				Quaternion rot = transform.rotation;

				rot = Quaternion.Inverse (rot);
              
				transform.rotation = rot;
           
        
        
		}
}
