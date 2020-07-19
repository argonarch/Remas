using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Botoini2 : MonoBehaviour
{
    public static Botoini2 ard;
    void Start()
    {
        ard= this;
    }
    public void priB(byte rader)
    {
        if (rader == 1)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
    }
}
