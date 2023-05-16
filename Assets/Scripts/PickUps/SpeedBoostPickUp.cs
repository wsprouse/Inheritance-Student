using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostPickUp : PickUp
{
    public override void ActivatePickUp()
    {
        // Store the player's original speed
        float originalSpeed = player.moveSpeed;

        //Increase the player's speed
        player.moveSpeed *= 2.0f;

        // Start a coroutine to reset the speed after a certain duration
        StartCoroutine(ResetSpeed(originalSpeed, 5.0f));
    }

    private IEnumerator ResetSpeed(float originalSpeed, float duration)
    {

        Debug.Log("Coroutine Started!");
        // Wait for the specified duration
        yield return new WaitForSeconds(duration);
        
        // Reset the player's speed to the original value
        player.moveSpeed = originalSpeed;
    }
}
