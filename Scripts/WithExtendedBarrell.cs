using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithExtendedBarrel : RifleDecorator
{
    private float m_ExtendedBarrelAccuracy = 20.0f;

    //constructor
    public WithExtendedBarrel(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ExtendedBarrelAccuracy;
    }
}
