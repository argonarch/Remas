using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static score puntscord;
    public Text scorea;
    byte punto = 0;
    byte sumador = 1;

    void Start()
    {
        puntscord = this;
    }

    // Update is called once per frame
    public void RaiseScore(byte a)
    {
        if (a == 1)
        {
            punto += sumador;
            scorea.text = punto + "";
        }else if (a == 2)
        {
            punto = 0;
            scorea.text = punto + "";
        }
        
    }
}
