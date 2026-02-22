using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    [SerializeField] 
    private float spawnRate = 60;
    [SerializeField]
    private float spawnHeightOffset = 10;

    private float _spawnTimer = 0;

    void Update()
    {
        SpawnPipe();
    }

    /// <summary>
    /// Spawns a prefab every spawnRate
    /// </summary>
    private void SpawnPipe()
    {
        if (_spawnTimer >= spawnRate)
        {
            //Gets the Bottom and top of _spawnHeightOffset
            var spawnHeightRange =Random.Range(transform.position.y - spawnHeightOffset, transform.position.y + spawnHeightOffset);
            Instantiate(prefab, new Vector3(transform.position.x, spawnHeightRange, 0), transform.rotation);
            _spawnTimer = 0;
        }
        else _spawnTimer += Time.deltaTime;
    }
}
