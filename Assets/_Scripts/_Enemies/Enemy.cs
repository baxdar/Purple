using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour {

    //add resistances at some point.  Not MK!
    public abstract void Attack();
    public abstract void Die();
}
