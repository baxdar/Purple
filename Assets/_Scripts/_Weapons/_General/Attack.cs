using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    public int BaseDamage;
    public float PersistTime;
    public bool DoFade = true;
    private SpriteRenderer display;

    private void DestroyAttack() {
        Destroy(gameObject, PersistTime);
        if (DoFade) {
            //basic fade here, steadily lower Alpha level over duration of persist
            //reach 0 when obect is destroyed
        }
    }

    public void Start() {
        display = GetComponent<SpriteRenderer>();
        DestroyAttack();
    }
}
