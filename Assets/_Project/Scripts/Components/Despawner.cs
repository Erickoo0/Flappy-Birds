using UnityEngine;

public class Despawner : MonoBehaviour
{
    [SerializeField]
    [Range(0f, 100f)]
    private float maxDistance = 20f;
    private Vector3 _startPosition;

    void Start()
    {
        //Saves the immediate object position as the start position
        _startPosition = transform.position;
    }

    void Update()
    {
        //Measures distance traveled based off current position - start position
        float distanceTravelled = Vector3.Distance(_startPosition, transform.position);

        if (distanceTravelled > maxDistance)
        {
            Destroy(gameObject);
        }
    }

}
