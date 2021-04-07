using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : Enemy
{
    public override void Start()
    {
        base.Start();
        lookDirection = (player.transform.position - transform.position).normalized;
    }
    public override void MoveTowardsPlayer()
    {
        if (!gameManagerScript.gameHasEnded)
        {
            //Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            rb.AddForce(lookDirection * speed);
        }
    }
}
