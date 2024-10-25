using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageOnContact : MonoBehaviour
{
    // Start is called before the first frame update
    private int Health;
    private float TotalDamage;
    private RemoveHeart other;

    private float damageCooldownTimeLeft = 0f;

    void Start()
    {
        Health = 5;
        Debug.Log("Health is set to 5");
        TotalDamage = 0f;
    }

    // Update is called once per frame
    void Update()
    {

       

            damageCooldownTimeLeft -= Time.deltaTime;

        

    }


    public void RemoveHeart(float TotalCurrentDamage)
    {
        if (TotalCurrentDamage == 1f)
        {
            HeartRemover("Heart1");
        }
        if (TotalCurrentDamage == 2f)
        {
            HeartRemover("Heart2");
        }
        if (TotalCurrentDamage == 3f)
        {
            HeartRemover("Heart3");
        }
        if (TotalCurrentDamage == 4f)
        {
            HeartRemover("Heart4");
        }
        if (TotalCurrentDamage == 5f)
        {

        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        

        if (collision.gameObject.CompareTag("Enemy Sphere"))
        {
            Debug.Log("Collision with enemy");
            Debug.Log(damageCooldownTimeLeft);
            if (damageCooldownTimeLeft <= 0f) {
                damageCooldownTimeLeft = 2f;
                Health = Health - 1;
                Debug.Log("Player has lost a heart. Health: " + Health.ToString());

                TotalDamage = TotalDamage + 1f;
                Debug.Log("Total Damage: " + TotalDamage.ToString());


                GameObject.Find("Heart" + (5 - Health).ToString()).GetComponent<RemoveHeart>().RemoveAHeart();

            }
            


        }
    }

    public void HeartRemover(string Heart)
    {
        // Debug.Log("ja");
        if (gameObject.name == Heart)
        {
            // Debug.Log("ja");
            //gameObject.
        }
    }
}
