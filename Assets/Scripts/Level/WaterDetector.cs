using UnityEngine;
using System.Collections;

public class WaterDetector : MonoBehaviour
{

		void OnTriggerEnter (Collider Hit)
		{
				if (Hit.rigidbody != null && Hit.tag == "Player") {
						transform.parent.GetComponent<Water> ().Splash (transform.position.x, Hit.rigidbody.velocity.y * Hit.rigidbody.mass / 40f);
				}
		}

		

}
