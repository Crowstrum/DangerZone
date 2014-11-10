using UnityEngine;
using System.Collections;

public class WallMove : MonoBehaviour 
{

    GameObject player;

    public float amountToRaiseBy = 1.0f;

    void Awake()
    {

        player = GameObject.FindGameObjectWithTag("Player");

    }

	// Use this for initialization
	void Start () 
    {

        StartCoroutine("MoveWall");

	}
	
	// Update is called once per frame
	void Update () 
    {


	
	}

    IEnumerator MoveWall()
    {
        float finalPosition = player.transform.position.y + 2.0f;

        while (transform.position.y != finalPosition)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y +
                amountToRaiseBy, transform.position.z);

           // yield return null;
            yield return new WaitForSeconds(0.5f);

        }

        yield return null;

    }

}
