using UnityEngine;
using System.Collections;

public class DodgeballScript : ItemBase {

    void onStart()
    {
    }

    public override void onThrow()
    {
        base.onThrow();
    }

    public override void onHit()
    {
        Destroy(gameObject, 5.0f);
    }

    void OnCollisionEnter()
    {
        //Debug.Log("OnCollisionEnter called");
        if (this.gameObject.tag == "ThrownItem")
        {
            //Debug.Log("Thrown Object has hit something");
            onHit();
        }
    }
}
