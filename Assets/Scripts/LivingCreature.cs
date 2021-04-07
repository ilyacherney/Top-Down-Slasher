using UnityEngine;

public class LivingCreature : MonoBehaviour
{
    public int speed = 200;
    public int health = 1;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    public virtual void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public virtual void TakeDamage()
    {
        health--;

        if (health <= 0)
        {
            Destroy(gameObject);
            
            if (CompareTag("Player"))
            {
                FindObjectOfType<GameManager>().EndGame();
            }
        }
    }
}
