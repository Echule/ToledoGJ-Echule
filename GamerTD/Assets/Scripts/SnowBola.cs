using UnityEngine;

public class SnowBola : MonoBehaviour
{
    public Rigidbody2D bolaRb;
    public float speed = 2.5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bolaRb.linearVelocity = Vector2.right * speed;
    }
}
