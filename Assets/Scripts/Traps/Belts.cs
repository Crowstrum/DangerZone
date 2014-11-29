using UnityEngine;
using System.Collections;

public class Belts : MonoBehaviour
{
		public bool MoveRight = false;

		void OnTriggerStay (Collider col)
		{
				switch (MoveRight) {
				case true:
						if (col.tag == "Player") {
								col.rigidbody.AddForce (Vector3.right * 600f);
						}
						break;
				case false:
						if (col.tag == "Player") {
								col.rigidbody.AddForce (Vector3.left * 600f);
						}
						break;
				}
				
		}
}
