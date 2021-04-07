using UnityEngine;

public class Enemy : LivingCreature
{
    public GameObject player;
    public GameManager gameManagerScript;
    public Vector3 lookDirection;

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        player = GameObject.Find("Player");
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    public virtual void Update()
    {
            MoveTowardsPlayer();
    }

    public virtual void MoveTowardsPlayer()
    {   
        if (!gameManagerScript.gameHasEnded)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            rb.AddForce(lookDirection * speed);
        }
    }
}
