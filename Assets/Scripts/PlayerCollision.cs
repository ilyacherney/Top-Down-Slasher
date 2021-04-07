using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Damage enemy
        if (other.CompareTag("Enemy") && player.isDashing)
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage();
        }
        // Damage player
        else if (other.CompareTag("Enemy"))
        {
            player.TakeDamage();
        }
    }
}
