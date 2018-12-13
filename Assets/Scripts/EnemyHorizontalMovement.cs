using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float moveSpeed = 2f;  // SÄTER FARTEN PÅ FIENDEN 
    public bool isLeft = true;
    private Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H)) // om man trycker h så flippar man fienden
        {
            Move(true);
        }
    }

    void Move(bool flip) //om is left är sant så flippar man fienden om is Rihgt är sant så flippar en fienden 
    {
        if (flip == true)
        {
            isLeft = !isLeft;
        }

        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    }
}
