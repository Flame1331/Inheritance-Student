using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickup : Pickup
{
    public Weapon Weapon;
    public override void Activate()
    {
        Destroy(Player.defaultWeapon.gameObject); Destroy(Player.equippedWeapon.gameObject);
        Player.defaultWeapon = Weapon;
        Player.EquipWeapon(Weapon);
    }

    private void OnDestroy()
    {
        PickupSpawner.Spawncount--;
        Debug.Log("destroyed Count: " + PickupSpawner.Spawncount);
    }
}