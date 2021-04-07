using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : LivingCreature
{
    public bool isDashing = false;

    // Update is called once per frame
    void Update()
    {
        Dash();
    }

    private void Dash()
    {
        if (Input.touchCount > 0 && !isDashing)
        {
            isDashing = true;

            StartCoroutine(DashingCountdownRoutine());

            // Getting touch position
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;

            // Getting destination and moving towards
            Vector3 dashDestination = (touchPosition - transform.position).normalized;
            rb.AddForce(dashDestination * speed);
        }
    }
    // Timer between dashes
    IEnumerator DashingCountdownRoutine()
    {
        yield return new WaitForSeconds(0.4f);
        isDashing = false;
    }
}
