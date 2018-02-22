using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour {
    public Weapon EquippedWeapon;
    public int Health = 10;
    public int Damage = 1;
    public int AttackSpeed;
    public float movespeed = 5;
    private Rigidbody2D charRigidBody;
    private Vector2 movement;

	void Start () {
        charRigidBody = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        if (Input.GetButton("Fire1")) {
            EquippedWeapon.PrimaryAttack();
        }
        if (Input.GetButton("Fire2")) {
            EquippedWeapon.SpecialAttack();
        }
        transform.rotation = new Quaternion();
    }

    private void FixedUpdate() {
        charRigidBody.velocity = new Vector2(movement.x * movespeed, movement.y * movespeed);
    }
}
