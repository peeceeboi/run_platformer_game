using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveHeart : MonoBehaviour
{
    // Start is called before the first frame update

   public Image myImage;
    bool hasDamaged = false;

    void Start()
    {
        myImage = GetComponent<Image>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RemoveAHeart()
    {

           gameObject.SetActive(false);
        //if (!hasDamaged) {

        //    hasDamaged = true;
        //    myImage.enabled = false;
        //}
        

        //Debug.Log(myImage.name);
        //if (myImage.name == Heart)
        //{
        //    myImage.enabled = false;
        //}

        //if (gameObject.CompareTag("Heart1"))
        //{
        //    gameObject.SetActive(false);
        //}

        //if (gameObject.CompareTag("Heart2"))
        //{
        //    gameObject.SetActive(false);
        //}

        //if (gameObject.CompareTag("Heart3"))
        //{
        //    gameObject.SetActive(false);
        //}

        //if (gameObject.CompareTag("Heart4"))
        //{
        //    gameObject.SetActive(false);
        //}

        //if (gameObject.CompareTag("Heart5"))
        //{
        //    gameObject.SetActive(false);
        //}


    }
}
