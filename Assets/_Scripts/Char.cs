using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour {
    public Entity.Health healthstat = new Entity.Health(15);
    public Weapon EquippedWeapon;
    public int Damage = 1;
    public int AttackSpeed = 1;
    public float movespeed = 5;
    public float chance = 5;
    public float luck = 0;
    private Rigidbody2D charRigidBody;
    private Vector2 movement;

	void Start () {
        charRigidBody = GetComponent<Rigidbody2D>();
        healthstat.DamageDelegate += TestDamage;
	}

    public void TestDamage() {
        Debug.Log("oof");
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
        if (Input.GetButton("Submit")) {
            healthstat.DamageDelegate();
        }
        transform.rotation = new Quaternion();
    }

    private void FixedUpdate() {
        charRigidBody.velocity = new Vector2(movement.x * movespeed, movement.y * movespeed);
    }
}
