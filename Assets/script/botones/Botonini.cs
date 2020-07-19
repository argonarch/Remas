using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botonini : MonoBehaviour
{
    public static Botonini ard;
    void Start()
    {
        gameObject.GetComponent<Button>().interactable = false;
        ard= this;
    }
    public void priB(byte rader)
    {
        if (rader == 0)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
}
