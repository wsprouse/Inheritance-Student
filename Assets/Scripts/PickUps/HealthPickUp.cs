using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : PickUp
{
    public float healValue;

    public override void ActivatePickUp()
    {
        player.health += healValue;
        if(player.health > player.maxHealth)
        {
            player.health = player.maxHealth;
        }
    }
}
