using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dangerous : MonoBehaviour {

    public float Damage = 1;
    public bool DamageAll = false;

    private void OnCollisionEnter2D(Collision2D collision) {
        Entity temp = collision.transform.GetComponent<Entity>();
        if (temp != null) { //If null then the rigidbody isn't damageable in the first place
            if(DamageAll == true || temp.transform.GetComponent<Char>() != null ) {
                temp.Health.Value = temp.Health.Value - Damage;
            }
        }
    }
}
