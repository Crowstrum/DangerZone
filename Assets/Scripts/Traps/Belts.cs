using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Belts : MonoBehaviour
{
		public bool MoveRight = false;
		public GameObject cog;
		public List<GameObject> cogs;

		void OnTriggerStay (Collider col)
		{
				foreach (GameObject c in cogs) {
						c.transform.Rotate (Vector3.back * Time.deltaTime * 900f);
				}
				switch (MoveRight) {
				case true:
						if (col.tag == "Player") {
								col.rigidbody.AddForce (Vector3.right * 900f);
						}
						break;
				case false:
						if (col.tag == "Player") {
								col.rigidbody.AddForce (Vector3.left * 900f);
						}
						break;
				}
				
		}
}
