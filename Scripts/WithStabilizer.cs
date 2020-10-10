using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithStabilizer : RifleDecorator
{
    private float m_StabilizerAccuracy = 10.0f;

    //constructor
    public WithStabilizer(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_StabilizerAccuracy;
    }
}
