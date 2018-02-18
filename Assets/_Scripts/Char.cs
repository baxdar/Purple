using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour {
    public float movespeed = 5;
    private Rigidbody2D charRigidBody;
    private Vector2 movement;

	void Start () {
        charRigidBody = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        transform.rotation = new Quaternion();
    }

    private void FixedUpdate() {
        charRigidBody.velocity = new Vector2(movement.x * movespeed, movement.y * movespeed);
    }
}
