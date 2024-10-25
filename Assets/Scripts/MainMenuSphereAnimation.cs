using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuSphereAnimation : MonoBehaviour
{
    Rigidbody2D myRigidbody;
    public float Speed = 2f;
    public float jumpForce = 1f;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 movement = new Vector2(1f, 1f);
        myRigidbody.AddForce(movement * Speed * Time.deltaTime);
        if (gameObject.transform.position.x > 11.3f)
        {
            float num = Random.Range(-11.88f, 2.17f);
            Vector2 temp = new Vector2(num, -5.31f);
            Speed = Random.Range(30f, 50f);
            gameObject.transform.position = temp;

        }
    }
}
