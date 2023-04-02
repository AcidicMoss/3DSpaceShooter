using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
public ShipController shipController;
float boostDuration = 3f; // Duration of the boost in seconds
float boostMultiplier = 2f; // Multiplier for the boost
bool isSpeedBoostActive = false; // Flag to keep track of whether speed boost is active or not
bool isCooldownActive = false; // Flag to keep track of whether the cooldown is active or not
float cooldownDuration = 5f; // Cooldown duration in seconds

void Update()
{
    if (Input.GetKeyDown(KeyCode.LeftShift) && !isSpeedBoostActive && !isCooldownActive) // Check if speed boost is not currently active and the cooldown is not active
    {
        StartCoroutine(ApplySpeedBoost()); // Start coroutine to apply speed boost
    }
}

IEnumerator ApplySpeedBoost()
{
    isSpeedBoostActive = true; // Set flag to true to indicate that speed boost is currently active
    float originalThrustForce = shipController._thrustForce; // Store the original thrust force

    // Apply the speed boost by increasing the thrust force
    shipController._thrustForce *= boostMultiplier;

    yield return new WaitForSeconds(boostDuration); // Wait for the boost duration

    // Revert the thrust force to its original value
    shipController._thrustForce = originalThrustForce;
    isSpeedBoostActive = false; // Set flag to false to indicate that speed boost is no longer active
    StartCoroutine(Cooldown()); // Start coroutine for the cooldown
}

IEnumerator Cooldown()
{
    isCooldownActive = true; // Set flag to true to indicate that the cooldown is active
    yield return new WaitForSeconds(cooldownDuration); // Wait for the cooldown duration
    isCooldownActive = false; // Set flag to false to indicate that the cooldown is over
}
}