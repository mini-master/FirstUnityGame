using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public float jump;
    private float Move;
    
    private Rigidbody2D rb;

    public bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }
}


// using System;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerMove : MonoBehaviour
//{
// public float speed;
// public float jumpheight;
// private float Move;
// private bool IsJumping;

// private Rigidbody2D rb;

////////////////////////////////public bool isJumping;
////// Start is called before the first frame update
// void Start()
//{
// rb = GetComponent<Rigidbody2D>();
// IsJumping = false;
//}

/////////////////////////////// Update is called once per frame
// void Update()
//{
// rb.velocity = new Vector2(speed * Move, rb.velocity.y);

// Move = Input.GetAxis("Horizontal");

//if (Input.GetButtonDown("Jump"))
// Jump();
//}

// private void Jump()
//{
// StartCoroutine(Jumper());
//}

// private IEnumerator Jumper()
//{
//if (!IsJumping)
//{
// IsJumping = true;
// rb.AddForce(new Vector2(rb.velocity.x, jumpheight));
// yield return new WaitForSeconds(1.5f);
// ResetIsJumping();

//}
//}

// private void ResetIsJumping()
//{
// IsJumping = false;
//}


//}