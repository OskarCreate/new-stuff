using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; // NUEVO: importar el nuevo Input System

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flatStrength;

    // Update is called once per frame
    void Update()
    {
        // NUEVO: usar el nuevo sistema de Input
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            myRigidbody.linearVelocity = Vector2.up * flatStrength;
        }
    }
}

