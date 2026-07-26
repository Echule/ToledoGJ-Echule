using UnityEngine;
using UnityEngine.UI;

public class IglooHP : MonoBehaviour
{

    public int health;
    public int maxHealth = 100;
    public Slider slider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = maxHealth;
        slider.maxValue = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = health;
        if(health <= 0)
        {
            Destroy(slider.gameObject);
            Destroy(gameObject);
        }
    }
}
