using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerLaberinto : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
   // [SerializeField] private Animator anim;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

    
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, vertical*speed);      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Walls"))
        {
            Destroy(this.gameObject);
        }

        if (collision.CompareTag("Moon"))
        {
            Debug.Log("Llegué a la luna");
        }
    }

    
}
