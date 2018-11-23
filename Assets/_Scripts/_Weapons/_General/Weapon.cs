using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour {
    public GameObject AttackObject;
    public float AttackCooldown;
    protected bool AttackReady = true;

    //any attack specific oddities (velocity, multipe projectiles, etc.) 
    //should be dealt with in these methods
    public abstract void AttackMethod();
    public abstract void OnPickUp();
    public abstract void OnDrop();

    protected Vector2 MouseAim() {
        Vector2 temp = new Vector2();
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity)) {
            temp.x = hit.point.x - SceneManager.instance.SavedPlayer.transform.position.x;
            temp.y = hit.point.y - SceneManager.instance.SavedPlayer.transform.position.y;
            temp.Normalize();
        }
        return temp;
    }

    protected IEnumerator primarycooldown(float attackspeed) {
        //remember to add scaling
        AttackReady = false;
        yield return new WaitForSecondsRealtime(AttackCooldown);
        AttackReady = true;
    }
}
