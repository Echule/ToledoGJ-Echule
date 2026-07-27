using UnityEngine;

public class DefenderSpawn : MonoBehaviour
{
    public GameObject penguin;
    public GameObject penguinDos;
    public Transform spawnPoint;
    public Transform spawnPointDos;
    private bool hasSpawned = false;
    private bool hasSpawnedDos = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPenguin()
    {
        if(hasSpawned)
        {
            return;
        }
        Instantiate(penguin, spawnPoint.position, Quaternion.identity);
        hasSpawned = true;
    }

    public void SpawnPenguinDos()
    {
        if(hasSpawnedDos)
        {
            return;
        }
        Instantiate(penguinDos, spawnPointDos.position, Quaternion.identity);
        hasSpawnedDos = true;
    }
}
