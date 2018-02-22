using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {
    public GameObject PrimaryAttackObject;
    public GameObject SpecialAttackObject;
    public float PrimaryAttackCooldown;
    public float SpecialAttackCooldown;

    //any attack specific oddities (velocity, multipe projectiles, etc.) 
    //should be dealt with in these methods
    public abstract void PrimaryAttack();
    public abstract void SpecialAttack();

}
