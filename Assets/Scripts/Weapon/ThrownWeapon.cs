using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrownWeapon : Weapon
{
    public GameObject projectilePrefab;

    public override void Attack()
    {
        Projectile projectile = Instantiate(projectilePrefab, transform.position, transform.rotation).GetComponent<Projectile>();
        projectile.origin = gameObject.GetComponent<ThrownWeapon>();
        projectile.duration = attackDuration;
        projectile.GetComponent<Rigidbody2D>().WakeUp();
    }
}
