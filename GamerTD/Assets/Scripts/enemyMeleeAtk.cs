using UnityEngine;

public class enemyMeleeAtk : MonoBehaviour
{
    public int damage = 50;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<IglooHP>())
        {
            collision.gameObject.GetComponent<IglooHP>().health -= damage;  
            Destroy(gameObject);
        }
    }
}
