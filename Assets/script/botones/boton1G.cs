using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boton1G : MonoBehaviour
{
    public static boton1G ard;
    void Start()
    {
        gameObject.GetComponent<Button>().interactable = false;
        ard= this;
    }
    public void priB(byte rader)
    {
        if (rader == 15)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
}
