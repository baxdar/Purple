using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour {
    public float movespeed = 8;
    private Rigidbody2D charRigidBody;
    private Vector2 movement;

	// Use this for initialization
	void Start () {
        charRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate() {
        charRigidBody.velocity = new Vector2(movement.x * movespeed, movement.y * movespeed);
    }
}
