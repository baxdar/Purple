using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    public int BaseDamage;
    public float PersistTime;
    public bool DoFade = true;

    private void DestroyAttack() {
        Destroy(gameObject, PersistTime);
    }

    public void Start() {
        DestroyAttack();
    }
}
