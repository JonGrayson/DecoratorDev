﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithScope : RifleDecorator
{
    private float m_ScopeAccuracy = 20.0f;

    //constructor
    public WithScope(IRifle rifle) : base(rifle) { }

    public override float GetAccuracy()
    {
        return base.GetAccuracy() + m_ScopeAccuracy;
    }
}
