using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwungWeapon : Weapon
{
    //Swinging Variables
    public float swingSpeed;  //How fast I swing
    public float swingDegrees; //How far I swing

    public override void Attack()
    {
        //Start the attack cooldown
        Invoke("AttackReset", 60f / attackRate);
        //Rotate to starting position
        transform.localEulerAngles= new Vector3(0,0,-swingDegrees);
        //Turn on weapon
        EnableWeapon();
        //Swing down
        StartCoroutine(Swing());
        //Disable Weapon (in the swing)
    }

    //Write a Swinging Coroutine
    IEnumerator Swing()
    {
        float degrees = 0f;

        while (degrees < swingDegrees *2)
        {
            transform.Rotate(Vector3.forward, swingSpeed * Time.deltaTime);
            degrees += swingSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        DisableWeapon();
    }
}
