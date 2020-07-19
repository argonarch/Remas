using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boton2G : MonoBehaviour
{
    public static boton2G ard;
    void Start()
    {
        ard= this;
    }
    public void priB(byte rader)
    {
        if (rader == 16)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
}
