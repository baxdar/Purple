using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shortsword : Weapon {

    public override void AttackMethod() {
        float fakescaling = 0f;
        if (AttackReady) {
            StartCoroutine(primarycooldown(fakescaling));
            Vector3 StashedPosition = transform.position;
            StashedPosition = MouseAim();
            StashedPosition *= .625f;
            StashedPosition.x += SceneManager.instance.SavedPlayer.transform.position.x;
            StashedPosition.y += SceneManager.instance.SavedPlayer.transform.position.y;
            StashedPosition.z = -1;
            Instantiate(AttackObject, StashedPosition, new Quaternion());
        }
    }

    public override void OnDrop() {
        throw new System.NotImplementedException();
    }

    public override void OnPickUp() {
        throw new System.NotImplementedException();
    }

    void Start () {
        if (AttackCooldown == 0){
            AttackCooldown = 1;
        }
    }
}
