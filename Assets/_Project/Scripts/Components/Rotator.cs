using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Rotator : MonoBehaviour
{
    [Header("Rotation Settings")]
    public Rigidbody2D Rigidbody2D; // Reference to the Rigidbody2D component
    public float RotationSpeed = 10f; // Speed at which the object rotates
    public float TargetZUp = 45f; // Target Z angle when moving upwards
    public float TargetZDown = -30f; // Target Z angle when moving downwards

    public void Awake()
    {
        if (Rigidbody2D == null)
        {
            Rigidbody2D = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component if not assigned
        }
    }
    void Update()
    {
        ApplyRotation();
    }

    public void ApplyRotation()
    {
        // Determines target Z angle based on vertical velocity
        float targetZ = Rigidbody2D.linearVelocity.y < -0.1f ? TargetZDown : TargetZUp;
        // Converts targetZ to a Quaternion (angle) for rotation
        Quaternion targetRotation = Quaternion.Euler(0, 0, targetZ);
        // Smoothly rotates the object towards the target Z rotation at RotationSpeed
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * RotationSpeed);
    }
}
