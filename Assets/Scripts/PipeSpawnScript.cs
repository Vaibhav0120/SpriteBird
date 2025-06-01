using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnTime = 3.0f;
    private float elapsedTime = 0;
    public float heightOffset;

    void Start()
    {
        SpawnPipe(); 
    }

    void Update()
    {
        if (elapsedTime >= spawnTime)
        {
            SpawnPipe();
            elapsedTime = 0;
        }
        else
        {
            elapsedTime += Time.deltaTime;
        }
    }

    void SpawnPipe(){
            float minY = transform.position.y - heightOffset;
            float maxY = transform.position.y + heightOffset;
        Instantiate(pipePrefab, new Vector3(transform.position.x , Random.Range(minY, maxY), 100), Quaternion.identity);
    }
}
