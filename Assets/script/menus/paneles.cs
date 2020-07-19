using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paneles : MonoBehaviour
{
    public static paneles sas;
    byte rader = 0;
    byte cant_panel = 2;
    void Start()
    {
        sas = this;
    }
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            if (rader == cant_panel){
                rader = 0;
            }else{
                rader += 1;
            }
            inicio.ags.afg(rader);
            //para aclarar el paginas
            Botonini.ard.priB(rader);
            Botoini2.ard.priB(rader);
            Botoini3.ard.priB(rader);
        }else if (Input.GetKeyDown("down"))
        {
            if (rader == 0){
                rader = cant_panel;
            }else{
                rader -= 1;
            }
            inicio.ags.afg(rader);
            //para aclarar el pagina
            Botonini.ard.priB(rader);
            Botoini2.ard.priB(rader);
            Botoini3.ard.priB(rader);
        }
    }
    public void ars(byte s)
    {
        if (s == 1)
        {
            gameObject.SetActive(false);
        }else if (s == 2)
        {
            gameObject.SetActive(true);
        }
    }
}
