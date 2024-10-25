using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringUpPause : MonoBehaviour
{
    Canvas myCanvas;
    public void Pause()
    {
        myCanvas = GetComponent<Canvas>();
        if (myCanvas.enabled == false)
        {
            myCanvas.enabled = true;
            
        }
        else if (myCanvas.enabled == true)
        {
            myCanvas.enabled = false;
        }
    }
}
