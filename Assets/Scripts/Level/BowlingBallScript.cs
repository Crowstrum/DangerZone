using UnityEngine;
using System.Collections;

public class BowlingBallScript : ItemBase {
    
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
        if (this.gameObject.tag == "ThrownItem")
        {
            onHit();
        }
    }
}
