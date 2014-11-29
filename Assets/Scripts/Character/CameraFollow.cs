using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
		public GameObject flag;
    
		// Use this for initialization
		void Start ()
		{
	
		}
    
		void Update ()
		{
				var newX = flag.transform.position.x;
				//  var newZ = player.transform.position.z;
				var newY = flag.transform.position.y;
				var z = transform.position.z;
				var chaseSpeed = 0.6f;

				transform.position = transform.position +
						(new Vector3 (newX, newY, z) - transform.position) * chaseSpeed;
		}
}
