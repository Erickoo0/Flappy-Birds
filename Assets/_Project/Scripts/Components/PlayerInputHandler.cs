using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public FlapMotor FlapMotor; // Reference to the FlapMotor component

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            FlapMotor.Flap(); // Call the Flap method on the FlapMotor component when space key is pressed
        }                       
    }
}
