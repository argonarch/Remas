using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincolision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score.puntscord.RaiseScore(1);
        ser.ars.corrida(10);
        coin.asd.ads(true);
        Destroy(gameObject);
    }
}
