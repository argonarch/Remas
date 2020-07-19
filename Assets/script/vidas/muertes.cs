using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muertes : MonoBehaviour
{
    public static muertes coros;
    byte ok = 0;
    void Start()
    {
        coros = this;
    }
    public void cod(byte f)
    {
        ok += f;
        if (ok == 1)
        {
            vidas.carl.bol(true);
        }else if (ok == 2)
        {
            vidas1.carl.bol(true);
        }else if (ok == 3)
        {
            vidas2.carl.bol(true);
        }else if (ok == 4)
        {
            vidas.carl.bol(false);
            vidas1.carl.bol(false);
            vidas2.carl.bol(false);
            paneles2.sas.ars(2);
            ser.ars.over(true);
            ok = 0;
        }

    }
}
