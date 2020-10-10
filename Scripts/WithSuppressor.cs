using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithSuppressor : RifleDecorator
{
    private float m_SuppressorAccuracy = 10.0f;

    //constructor
    public WithSuppressor(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_SuppressorAccuracy;
    }
}
