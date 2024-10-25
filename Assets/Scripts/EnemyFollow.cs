using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    Transform target;
    GameObject Player;
    Rigidbody2D enemyRigidbody;
    Transform EnemyPos;
    public float speed;

    CircleCollider2D enemyCircCollider;

    void Start()
    {
        EnemyPos = GetComponent<Transform>();
        Player = GameObject.FindWithTag("Player");
        enemyRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Player = GameObject.FindWithTag("Player");
        target = Player.transform;

        if (target.position.x > gameObject.transform.position.x - 8)// && target.position.x < gameObject.transform.position.x + 8)
        {
            
            if (gameObject.transform.position.x < target.position.x)
            {
                // Vector2 temp = new Vector2(1f, 0f);
                // enemyRigidbody.AddForce(temp * speed);
                enemyCircCollider = GetComponent<CircleCollider2D>();
                enemyCircCollider.enabled = false;
                

            }
            
            if (gameObject.transform.position.x > target.position.x)
            {
                Vector2 temp = new Vector2(1f, 0f);
                enemyRigidbody.AddForce(-temp * speed);
            }
            if (gameObject.transform.position.y < target.position.y)
            {
                Vector2 temp = new Vector2(0f, 1f);
                enemyRigidbody.AddForce(temp * speed);
            }
         
        }
    }
}
