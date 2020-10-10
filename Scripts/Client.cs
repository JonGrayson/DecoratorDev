using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown("b"))
        {
            IRifle rifle = new BasicRifle();
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
        }

        if(Input.GetKeyDown("s"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(rifle);
            Debug.Log("Basic accuracy: " + rifle.GetAccuracy());
        }

        if(Input.GetKeyDown("t"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithStabilizer(rifle));
            Debug.Log("Stabilizer + Scope: " + rifle.GetAccuracy());
        }

        if(Input.GetKeyDown("p"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithSuppressor(rifle));
            Debug.Log("Scope + Suppressor: " + rifle.GetAccuracy());
        }

        if(Input.GetKeyDown("l"))
        {
            IRifle rifle = new BasicRifle();
            rifle = new WithScope(new WithExtendedBarrel(rifle));
            Debug.Log("Scope + Extended Barrel: " + rifle.GetAccuracy());
        }
    }
}
