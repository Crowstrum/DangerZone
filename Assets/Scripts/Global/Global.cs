using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Global : MonoBehaviour
{
		public static Global Instance; 
		public List<ItemBase> gameItems;
		private GameObject playerOneGameObject;
		private GameObject playerTwoGameObject;

		void Awake ()
		{
				Instance = this;
		}
	#region Player
		public GameObject GetPlayerOneGO ()
		{
				return playerOneGameObject;
		}

		public GameObject GetPlayerTwoGO ()
		{
				return playerTwoGameObject;
		}

		public void SetPlayerOneGO (GameObject go)
		{
				playerOneGameObject = go;
		}

		public void SetPlayerTwoGO (GameObject go)
		{
				playerTwoGameObject = go;
		}
		#endregion

	#region Items
		public ItemBase GetRandomItem ()
		{
				return gameItems [Random.Range (0, gameItems.Count)];
		}
		
#endregion
}
