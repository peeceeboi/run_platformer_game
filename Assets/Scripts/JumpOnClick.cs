    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpOnClick : MonoBehaviour
{
    public float jumpForce;
    public float timeBetweenJumps;
    private float timeBetweenJumpsCount;
    private Rigidbody2D myRigidbody2D;
    private bool canJump;
    private bool isGrounded;
   // private int timesJumped = 0;

    // Start is called before the first frame update
    public void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();

        canJump = true;
        isGrounded = true;
        timeBetweenJumpsCount = timeBetweenJumps;
    }

    // Update is called once per frame
    public void ButtonPressed()
    {

        if(canJump)
        {
            myRigidbody2D.AddForce(Vector2.up * jumpForce);
            canJump = false;
        }
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            canJump = true;
        }
    }
}
