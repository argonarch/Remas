using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidas : MonoBehaviour
{
    public static vidas carl;
    void Start()
    {
        carl = this;
    }
    public void bol(bool f)
    {
        if (f == true)
        {
            gameObject.SetActive(false);
        }else
        {
            gameObject.SetActive(true);
        }
    }
}