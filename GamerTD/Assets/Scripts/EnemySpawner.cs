using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public float spawntime = 2;

    public Button nextButton;

    private float timer;
    private int currentEnemy;
    private bool spawningStarted = false;

    void Start()
    {
        timer = spawntime;

        // El botón empieza desactivado
        nextButton.interactable = false;
    }

    void Update()
    {
        if (!spawningStarted)
        {
            return;
        }

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        Instantiate(
            enemyPrefab[currentEnemy],
            transform.position,
            Quaternion.identity
        );

        currentEnemy++;

        if (currentEnemy >= enemyPrefab.Length)
        {
            // Comenzamos a comprobar cuándo mueren todos
            StartCoroutine(CheckEnemies());

            // Dejamos de generar enemigos
            this.enabled = false;
        }

        timer = spawntime;
    }

    public void StartSpawning()
    {
        spawningStarted = true;
        timer = 0f;
    }

    IEnumerator CheckEnemies()
    {
        while (true)
        {
            // Busca todos los enemigos que tengan el script EnemyHP
            EnemyHP[] enemies = FindObjectsByType<EnemyHP>();

            // Si no queda ningún enemigo vivo
            if (enemies.Length == 0)
            {
                nextButton.interactable = true;
                break;
            }

            yield return new WaitForSeconds(0.5f);
        }
    }

    public void NextLevel()
    {
        // Cargar la siguiente escena
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
