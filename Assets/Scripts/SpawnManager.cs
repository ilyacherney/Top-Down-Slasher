using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;

    private float spawnRangeX = 10.5f;
    private float spawnRangeY = 4.5f;
    private float spawnDelay = 1.0f;
    private float spawnInterval = 1.0f;

    public GameManager gameManagerScript;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnInterval);
    }
    private Vector3 GenerateRandomPosition()
    {
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        float spawnPosY = Random.Range(-spawnRangeY, spawnRangeY);

        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, 0);

        return randomPos;
    }
    void SpawnEnemy()
    {
        if (!gameManagerScript.gameHasEnded)
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Instantiate(enemyPrefabs[enemyIndex], GenerateRandomPosition(), enemyPrefabs[enemyIndex].transform.rotation);
        }
    }
}
