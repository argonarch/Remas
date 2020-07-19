using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidas1 : MonoBehaviour
{
    public static vidas1 carl;
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
