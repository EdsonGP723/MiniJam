using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLaberinto : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(horizontal * speed, vertical*speed);
        aceleration();
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

    private void aceleration()
    {
        rb.velocity += (Vector2.right * (horizontal * speed * Time.fixedDeltaTime));

        if (horizontal == 0 && rb.velocity != Vector2.zero)
        {
            var x = rb.velocity.x;
            var sign = Mathf.Sign(x);
            rb.velocity -= (Vector2.right * ((speed * sign) * Time.fixedDeltaTime));
        }

        rb.velocity += (Vector2.up * (vertical * speed * Time.fixedDeltaTime));

        if (vertical == 0 && rb.velocity != Vector2.zero)
        {
            var y = rb.velocity.y;
            var sign = Mathf.Sign(y);
            rb.velocity -= (Vector2.up * ((speed * sign) * Time.fixedDeltaTime));
        }
    }
}
