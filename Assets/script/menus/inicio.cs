using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicio : MonoBehaviour
{
    public static inicio ags;
    byte tecla;
    void Start()
    {
        gameObject.SetActive(true);
        ags = this;
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Return) && tecla == 0)
        {
            paneles.sas.ars(1);
            ser.ars.over(false);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && tecla == 1)
        {

        }
        else if (Input.GetKeyDown(KeyCode.Return) && tecla == 2)
        {
            
        }
        else if (Input.GetKeyDown(KeyCode.Return) && tecla == 2)
        {
            
        }
        else if (Input.GetKeyDown(KeyCode.Return) && tecla == 15)
        {
            paneles2.sas.ars(11);
        }
        else if (Input.GetKeyDown(KeyCode.Return) && tecla == 16)
        {
            paneles2.sas.ars(1);
            score.puntscord.RaiseScore(2);
            ser.ars.over(true);
            paneles.sas.ars(2);
        }
    }
    public void afg(byte s)
    {
        tecla = s;
    }
}
