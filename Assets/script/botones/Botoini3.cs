using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botoini3 : MonoBehaviour
{
    public static Botoini3 ard;
    void Start()
    {
        ard= this;
    }
    public void priB(byte rader)
    {
        if (rader == 2)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
}
