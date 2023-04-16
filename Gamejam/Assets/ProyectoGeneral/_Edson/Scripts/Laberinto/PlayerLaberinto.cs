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
    [SerializeField] private Animator anim;

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if(horizontal == -1)
        {
            anim.SetBool("Left", true);
        }
        else { anim.SetBool("Left", false); }

        if (horizontal == 1)
        {
            anim.SetBool("Right", true);
        }
        else { anim.SetBool("Right", false); }


    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizontal * speed, vertical*speed, 0f);      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Walls"))
        {
            var gameover = GetComponent<SceneController>();
            gameover.CambioEscena();
            Destroy(this.gameObject);
        }

        if (collision.CompareTag("Moon"))
        {
            Debug.Log("Llegué a la luna");
        }
    }

    
}
