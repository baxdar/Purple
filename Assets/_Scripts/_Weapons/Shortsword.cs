using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shortsword : Weapon {

    public override void PrimaryAttack() {
        Vector3 StashedPosition = transform.position;
        StashedPosition.y += .5f;
        Instantiate(PrimaryAttackObject, StashedPosition, new Quaternion());
    }

    public override void SpecialAttack() {
        throw new System.NotImplementedException();
    }

    void Start () {
		
	}
}
