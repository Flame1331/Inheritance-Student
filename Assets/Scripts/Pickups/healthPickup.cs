using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthPickup : Pickup
{
    public float HealValue; // how much to heal


    public override void Activate()
    {
        Player.health += HealValue;
        if(Player.health > Player.maxhealth)
        {
            Player.health = Player.maxhealth;
        }
    }

}
