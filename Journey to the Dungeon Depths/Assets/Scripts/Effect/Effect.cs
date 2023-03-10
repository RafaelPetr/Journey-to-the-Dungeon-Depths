using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect {
    protected bool isPositive;
    public int duration;

    //Each effect will append to a different GameManager Event?

    public abstract void Execute();
}
