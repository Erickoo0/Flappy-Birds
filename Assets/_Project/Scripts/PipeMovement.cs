using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float moveSpeed = 1;


    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);
    }
}
