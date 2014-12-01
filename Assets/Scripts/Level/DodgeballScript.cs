using UnityEngine;
using System.Collections;

public class DodgeballScript : ItemBase {

    private float timer;
    public float origTimer;

    void Awake()
    {
        timer = origTimer;
    }

    IEnumerator Start()
    {
        while (true)
        {
            if (this.gameObject.tag == "ThrownItem")
            {
                timer -= 1.0f;
                if (timer <= 0.0f)
                {
                    onHit();
                }
            }
            else
            {
                timer = origTimer;
            }

            Debug.Log(timer.ToString());

            yield return new WaitForSeconds(1.0f);
        }
    }
    public override void onHit()
    {
        Destroy(gameObject);
    }
}
