using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    public float speed = 1.5f;
    Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //float moveHorizontal = 1f;

        //Vector2 movement = new Vector2(moveHorizontal, 0f);

        //myRigidbody.AddForce(movement * speed * Time.deltaTime);

        float currentXPosition = myRigidbody.position.x;
        Vector2 temp = new Vector2(currentXPosition + (speed * Time.deltaTime), 0f);
        myRigidbody.position = temp;
    }
    public void Toggle(int num2)
    {
        if (num2 == 0)
        {
            myRigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
        }
        if (num2 == 1)
        {
                myRigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
    }
}
