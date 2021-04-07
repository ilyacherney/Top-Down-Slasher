//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerController : Player
//{
//    public bool isDashing = false;
//    //private Rigidbody2D rb;
//    //public float speed = 1.0f;
//    //public int health = 3;

//    // Start is called before the first frame update
//    new void Start()
//    {
//        base.Start();
//        //rb = GetComponent<Rigidbody2D>();
//    }

//    // Update is called once per frame
//    new void Update()
//    {
//        base.Update();
//        Dash();
//    }

//    private void Dash()
//    {
//        if (Input.touchCount > 0 && !isDashing)
//        {
//            isDashing = true;

//            StartCoroutine(DashingCountdownRoutine());

//            // Getting touch position
//            Touch touch = Input.GetTouch(0);
//            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
//            touchPosition.z = 0f;
//            Debug.Log($"touch position {touchPosition}");

//            // Getting destination and moving towards
//            Vector3 dashDestination = (touchPosition - transform.position).normalized;
//            Debug.Log($"destinaion {dashDestination}");
//            rb.AddForce(dashDestination.normalized * speed);
//        }
//    }
//    // Timer between dashes
//    IEnumerator DashingCountdownRoutine()
//    {
//        yield return new WaitForSeconds(0.4f);
//        isDashing = false;
//    }
//    // Damage player
//    //public void TakeDamage()
//    //{
//    //    health--;

//    //    if (health <= 0)
//    //    {
//    //        Destroy(gameObject);
//    //        FindObjectOfType<GameManager>().EndGame();
//    //    }
//    //}
//}
