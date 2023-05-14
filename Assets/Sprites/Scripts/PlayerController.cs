using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
   // public Weapon equippedWeapon;

    private Camera mainCamera;
    private Vector2 mousePos;

    private Vector2 movement;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Get movement input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Get mouse position and calculate aim direction
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = (mousePos - (Vector2)transform.position).normalized;

        // Get starting rotation of player sprite
        Quaternion startingRotation = Quaternion.AngleAxis(90f, Vector3.forward);

        // Rotate player to face mouse position
        Quaternion targetRotation = Quaternion.LookRotation(Vector3.forward, lookDir) * startingRotation;
        transform.rotation = targetRotation;

        // Set aim direction of equipped weapon
        // equippedWeapon.SetAimDirection(aimDir);

        // Check for fire input
        if (Input.GetButtonDown("Fire1"))
        {
            // equippedWeapon.Fire();
            Debug.Log("Fire");
        }
    }

    void FixedUpdate()
    {
        // Move player based on movement input
        transform.Translate(movement * moveSpeed * Time.fixedDeltaTime, Space.World);
    }
}
