using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour
{

		public GameObject chargingPart;
		public GameObject laserPart;
		
	
		public float speed;
		public bool laserActive;
	
		private Vector3 pointA;
		private Vector3 pointB;
	
	
		IEnumerator Start ()
		{

		
				while (true) {
						yield return StartCoroutine (ChargeUp ());
						yield return new WaitForSeconds (3.0f);
						yield return StartCoroutine (FireLaser ());
						yield return new WaitForSeconds (1.5f);
						laserActive = false;
						yield return new WaitForSeconds (3.0f);
						
						
				}
		}
	
		IEnumerator FireLaser ()
		{
				Debug.Log ("here");

				float i = 0.0f;
				float rate = 1.0f / 1.0f;
				while (i < 1.0f) {
						i += Time.deltaTime * rate;
						laserPart.GetComponent<ParticleSystem> ().Play ();
						laserActive = true;
						yield return 0; 
				}
		}

		IEnumerator ChargeUp ()
		{
				float i = 0.0f;
				float rate = 1.0f / 1.0f;
				while (i < 1.0f) {
						i += Time.deltaTime * rate;
						chargingPart.GetComponent<ParticleSystem> ().Play ();
						yield return 0; 
				}
		}

		void Update ()
		{
				//Debug.Log (laserActive);
		}
}
