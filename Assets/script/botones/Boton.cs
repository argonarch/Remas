using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boton : MonoBehaviour
{
    float tiempo;
    void Update()
    {
        tiempo += Time.deltaTime;
        if (tiempo < 1)
        {
            gameObject.GetComponent<Button>().interactable = false;
        }else
        {
            gameObject.GetComponent<Button>().interactable = true;
        }
        if (tiempo > 2)
        {
            tiempo = 0;
        }
    }
}
