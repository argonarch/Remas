using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameover : MonoBehaviour
{
    public static gameover gos;
    byte tecla;
    void Start()
    {
        gameObject.SetActive(true);
        gos = this;
    }
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Return) && tecla == 1)
        {
            gameObject.SetActive(false);
            ser.ars.over(false);
            score.puntscord.RaiseScore(2);
        }
        if (Input.GetKeyDown(KeyCode.Return) && tecla == 2)
        {

        }
    }
    public void arch(byte g)
    {
        tecla = g;
    }
    public void gas(bool r)
    {
        if (r == true)
        {
            gameObject.SetActive(true);
        }
    }
}
