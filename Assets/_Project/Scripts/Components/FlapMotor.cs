using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FlapMotor : MonoBehaviour
{
    public static FlapMotor Instance; //Saves an ID of itself
    public Rigidbody2D Rigidbody2D; // Reference to the Rigidbody2D component
    public float FlapStrength = 5f; // Strength of the flap

    private void Awake()
    {
        Instance = this; //Passed its own ID to variable
        if (Rigidbody2D == null)
        {
            Rigidbody2D = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component if not assigned
        }
    }
    public void Flap()
    {
               Rigidbody2D.linearVelocity = Vector2.up * FlapStrength; // Apply an upward force to the Rigidbody2D
    }

}
