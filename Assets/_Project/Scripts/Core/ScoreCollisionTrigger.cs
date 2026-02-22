using UnityEngine;
using System;

public class ScoreCollisionTrigger : MonoBehaviour
{
    //What ID do we want the collisions to trigger with
    [SerializeField] private LayerMask layerMask;

    // This belongs to the CLASS, not the instance. 
    // Any script can listen to this without a reference!
    public static event Action OnPipePassed;

    /// <summary>
    /// Sends out a signal on collision with layerMask
    /// </summary>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((layerMask.value & (1 << collision.gameObject.layer)) != 0)
        {
            OnPipePassed?.Invoke();
        }
    }
}
