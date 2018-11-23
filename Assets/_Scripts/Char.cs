using UnityEngine;

public class Char : Entity {
    public Weapon PrimaryWeapon;
    public Weapon SecondaryWeapon;
    public int Damage = 1;
    public int AttackSpeed = 1;
    public float movespeed = 5;
    public float chance = 5;
    public float luck = 0;
    private Rigidbody2D charRigidBody;
    private Vector2 movement;

	void Start () {
        charRigidBody = GetComponent<Rigidbody2D>();
        Health = new HealthClass(10);
        Health.DamageDelegate += TestDamage;
	}

    public void TestDamage() {
        Debug.Log("oof : " + Health.Value);
    }
	
	void Update () {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        if (Input.GetButton("Fire1") && PrimaryWeapon != null) {
            PrimaryWeapon.AttackMethod();
        }
        if (Input.GetButton("Fire2") && SecondaryWeapon != null) {
            SecondaryWeapon.AttackMethod();
        }
        if (Input.GetButtonDown("Submit")) {
            Debug.Log(Health.Value);
        }
        transform.rotation = new Quaternion();
    }

    private void FixedUpdate() {
        charRigidBody.velocity = new Vector2(movement.x * movespeed, movement.y * movespeed);
    }

    public override void Die() {
        //play death anim or revive
        throw new System.NotImplementedException();
    }
}
