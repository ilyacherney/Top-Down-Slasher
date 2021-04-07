using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : Enemy
{
    private float spellRange = 7.0f;
    private float distanceToPlayer;
    private bool isCasting = false;

    public override void Update()
    {
        base.Update();
        distanceToPlayer = Vector3.Distance(player.transform.position, transform.position);
    }
    
    public override void MoveTowardsPlayer()
    {
        // Chase player until it's close enough to cast a spell
        if (!gameManagerScript.gameHasEnded && distanceToPlayer >= spellRange && !isCasting)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            rb.AddForce(lookDirection * speed);
        }
        else if (!gameManagerScript.gameHasEnded && distanceToPlayer <= spellRange)
        {
            Spell();
        }
    }
    IEnumerator CastingCountdownRoutine()
    {
        yield return new WaitForSeconds(1.4f);
        isCasting = false;
    }
    public void Spell()
    {
        isCasting = true;
        StartCoroutine(CastingCountdownRoutine());

        Debug.Log("Pew pew its magic");
    }
}
