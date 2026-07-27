using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    public int health;
    public int maxHealth = 20;
    public float delayTime = .15f;
    public enemymove enemyMove;
    public GameObject popUpDamagePrefab;
    public TMP_Text popUpText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
    }


    public void TakeDamage(int damage)
    {
        health -= damage;
        popUpText.text = damage.ToString();
        Instantiate(popUpDamagePrefab, transform.position, Quaternion.identity);
        StartCoroutine(knockbackDelay());
    }

    IEnumerator knockbackDelay()
    {
        enemyMove.enabled = false;
        yield return new WaitForSeconds(delayTime);
        if(health <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            enemyMove.enabled = true;
        }
    }
}
