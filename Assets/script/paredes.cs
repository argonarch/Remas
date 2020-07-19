using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paredes : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
        {
            ser.ars.choque(true);
            muertes.coros.cod(1);
        }
}
