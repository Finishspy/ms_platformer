using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;

    private Rigidbody2D rbody;
    public GroundCheck groundCheck; //kollar om du nuddar marken

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed, 
            rbody.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space)) //gör så du kan hoppa och hur högt 
        {
            if (groundCheck.touches > 0) 
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }
}
