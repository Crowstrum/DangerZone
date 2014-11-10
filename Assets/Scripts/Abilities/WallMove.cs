using UnityEngine;
using System.Collections;

public class WallMove : MonoBehaviour 
{

    GameObject player;

    public float timer = 3.0f;

    public float amountToRaiseBy = 0.0005f;

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

        timer -= Time.deltaTime;

        Debug.Log(timer);

        if (timer <= 0)
        {

            Destroy(gameObject);

            timer = 3.0f;

        }
	
	}

    IEnumerator MoveWall()
    {
        float finalPosition = player.transform.position.y - 0.8f;

        while (transform.position.y < finalPosition)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y +
                amountToRaiseBy, transform.position.z);

           // yield return null;
            yield return new WaitForSeconds(0.01f);

        }

        yield return null;

    }

}
