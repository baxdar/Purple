using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {
    public GameObject PrimaryAttackObject;
    public GameObject SpecialAttackObject;
    public float PrimaryAttackCooldown;
    public float SpecialAttackCooldown;
    protected bool PrimaryAttackReady = true;
    protected bool SpecialAttackReady = true;

    //any attack specific oddities (velocity, multipe projectiles, etc.) 
    //should be dealt with in these methods
    public abstract void PrimaryAttack();
    public abstract void SpecialAttack();

    protected IEnumerator primarycooldown(float attackspeed) {
        //remember to add scaling
        PrimaryAttackReady = false;
        yield return new WaitForSecondsRealtime(PrimaryAttackCooldown);
        PrimaryAttackReady = true;
    }

    protected IEnumerator specialcooldown(float attackspeed) {
        //remember to add scaling
        SpecialAttackReady = false;
        yield return new WaitForSecondsRealtime(SpecialAttackCooldown);
        SpecialAttackReady = true;
    }
}
