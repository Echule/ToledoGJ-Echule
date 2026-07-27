using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IglooHP : MonoBehaviour
{

    public int health;
    public int maxHealth = 100;
    public Slider slider;
    public GameObject popUpDamagePrefab;
    public TMP_Text popUpText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        health -= damage;
        popUpText.text = damage.ToString();
        Instantiate(popUpDamagePrefab, transform.position, Quaternion.identity);
        

        slider.value = health;
        if(health <= 0)
        {
            Destroy(slider.gameObject);
            Destroy(gameObject);
        }
    }
}
