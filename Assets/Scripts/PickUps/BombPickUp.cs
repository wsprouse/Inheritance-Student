using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPickUp : PickUp
{
    public override void ActivatePickUp()
    {
        // Find all GameObjects with the "Enemy" tag
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        // Loop through each enemy and destroy it
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
    }
}
