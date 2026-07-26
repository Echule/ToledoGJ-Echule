using UnityEngine;

public class enemymove : MonoBehaviour
{
    public Rigidbody2D EnemyRb;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        EnemyRb.linearVelocity = Vector2.left * speed;
    }
}
