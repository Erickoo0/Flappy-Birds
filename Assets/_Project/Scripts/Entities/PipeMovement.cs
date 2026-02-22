using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 0.25f;


    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);
    }
}
