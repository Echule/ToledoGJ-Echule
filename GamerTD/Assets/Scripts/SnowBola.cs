using UnityEngine;

public class SnowBola : MonoBehaviour
{
    public Rigidbody2D bolaRb;
    public float speed = 2.5f;
    public float range = 1;
    private float timer;
    public int damage = 5;
    public float knockbackForce = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = range;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bolaRb.linearVelocity = Vector2.right * speed;

        timer -= Time.fixedDeltaTime;
        if(timer <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<EnemyHP>())
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * knockbackForce, ForceMode2D.Impulse);
            collision.gameObject.GetComponent<EnemyHP>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
