using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paneles2 : MonoBehaviour
{
    public static paneles2 sas;
    byte rader = 15;
    byte cant_panel = 16;

    void Start() 
    {
        gameObject.SetActive(false);
        sas = this;
    }
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            if (rader == cant_panel){
                rader = 15;
            }else{
                rader += 1;
            }
            inicio.ags.afg(rader);
            //para aclarar el paginas
            boton1G.ard.priB(rader);
            boton2G.ard.priB(rader);
        }else if (Input.GetKeyDown("down"))
        {
            if (rader == 15){
                rader = cant_panel;
            }else{
                rader -= 1;
            }
            inicio.ags.afg(rader);
            //para aclarar el paginas
            boton1G.ard.priB(rader);
            boton2G.ard.priB(rader);
        }
    }
    public void ars(byte s)
    {
        if (s == 1)
        {
            gameObject.SetActive(false);

        }else if (s == 11)
        {
            gameObject.SetActive(false);
            ser.ars.over(false);
            score.puntscord.RaiseScore(2);
        }
        else if (s == 2)
        {
            gameObject.SetActive(true);
        }
    }
}
