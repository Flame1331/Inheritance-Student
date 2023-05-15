using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage = 8;
    public float ThrowSpeed = 15;

    public float piercing = 0;
    private float hits = 0;

    public GameObject sprite;

    private void Start()
    {
        GetComponent<ThrownWeapon>().enabled = false;
    }

    private void Update()
    {
        sprite.transform.Rotate(Vector3.forward * 360 * Time.deltaTime);
        transform.Translate(Vector2.right * ThrowSpeed * Time.deltaTime);
        if(hits >= piercing+1)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collider belongs to an enemy.
        if (collision.CompareTag("Enemy"))
        {
            // If it does, deal damage to the enemy.
            collision.GetComponent<Enemy>().TakeDamage(damage);
            hits++;
        }
    }
}
