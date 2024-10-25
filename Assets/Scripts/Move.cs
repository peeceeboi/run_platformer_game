using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    public float Speed = 2f;
    public float jumpForce;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }
    public void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                if (touch.position.x < Screen.width / 2 && touch.position.y > Screen.height / 3)
                {
                    Vector2 movement = new Vector2(1f, 0f);
                    myRigidbody.AddForce(-movement * Speed);
                }
                if(touch.position.x > Screen.width / 2 && touch.position.y > Screen.height / 3)
                {
                    Vector2 movement = new Vector2(1f, 0f);
                    myRigidbody.AddForce(movement * Speed);
                }

            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Vector2 movement = new Vector2(1f, 0f);
            myRigidbody.AddForce(movement * Speed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Vector2 movement = new Vector2(1f, 0f);
            myRigidbody.AddForce(-movement * Speed);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            myRigidbody.AddForce(Vector2.up * jumpForce);
        }
    }
    public void Toggle(int num)
    {
       if (num == 0)
        {
            myRigidbody.bodyType = RigidbodyType2D.Static;
            myRigidbody = null;
        }
       if (num == 1)
        {
            myRigidbody = GetComponent<Rigidbody2D>();
            myRigidbody.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
