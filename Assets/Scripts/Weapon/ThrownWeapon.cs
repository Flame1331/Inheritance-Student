using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownWeapon : Weapon
{
    //thrown Variables
    public float ThrowSpeed = 15f;
    public GameObject Knife;
    public GameObject sprite;
    public GameObject LaunchPoint;

    private void Start()
    {
        // Get the rigidbody, sprite renderer, and box collider components of the weapon.
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
        boxCollider = GetComponent<BoxCollider2D>();

            //transform.position = new Vector3(transform.position.x-.09f, -0.08f, transform.position.x);
            transform.localEulerAngles = new Vector3(0, 0, 90);
        Debug.Log("Knife Start Function");
    }

    public override void Attack()
    {
        if (canAttack)
        {

            EnableWeapon();
            // Set a timer to reset the weapon's attack ability.
            Invoke("AttackReset", 60f / attackRate);
            var x = Instantiate(Knife, transform.position, LaunchPoint.transform.rotation);

            x.GetComponent<Projectile>().enabled = true;
            x.GetComponent<Projectile>().damage = damage;
            x.GetComponent<Projectile>().ThrowSpeed = ThrowSpeed;
            x.GetComponent<Rigidbody2D>().isKinematic = false;
            x.GetComponent<ThrownWeapon>().enabled = false;
            StartCoroutine(Duration(x));
        }
    }



    IEnumerator Duration(GameObject o)
    {
        yield return new WaitForSeconds(2);
        Destroy(o);
    }
}
