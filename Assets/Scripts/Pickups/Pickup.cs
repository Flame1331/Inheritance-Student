using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    public PlayerController Player;
    public float duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Player = collision.gameObject.GetComponent<PlayerController>();
            Activate();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Invoke(nameof(DelayedDestroy), duration);
        }
    }

    public virtual void Activate()
    {

    }

    public void DelayedDestroy()
    {
        Destroy(gameObject);
    }

}
