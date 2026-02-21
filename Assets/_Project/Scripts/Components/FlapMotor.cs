using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FlapMotor : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D; // Reference to the Rigidbody2D component
    public float FlapStrength = 5f; // Strength of the flap

    private void Awake()
    {
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
