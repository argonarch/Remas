using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ser : MonoBehaviour
{
    public static ser ars;
    byte mov = 0;
    bool fofo;
    float acel = 300;
    void Start()
    {
        ars = this;
        fofo = false;
        gameObject.transform.position = new Vector3(250, -90, 0);
        gameObject.GetComponent<Animator>().SetBool("est", false);
    }

    void Update()
    {
        if (fofo == true)
        {
            if (mov == 3)
            {
                gameObject.transform.Translate(0, acel * Time.deltaTime, 0);
                gameObject.GetComponent<Animator>().SetBool("est", false);
                gameObject.GetComponent<SpriteRenderer>().flipY = false;
            }else if (mov == 4)
            {
                gameObject.transform.Translate(0, (-1 * acel) * Time.deltaTime, 0);
                gameObject.GetComponent<Animator>().SetBool("est", false);
                gameObject.GetComponent<SpriteRenderer>().flipY = true;
            }else if (mov == 1)
            {
                gameObject.transform.Translate((-1 * acel) * Time.deltaTime, 0, 0);
                gameObject.GetComponent<Animator>().SetBool("est", true);
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }else if (mov == 2)
            {
                gameObject.transform.Translate(acel * Time.deltaTime, 0, 0);
                gameObject.GetComponent<Animator>().SetBool("est", true);
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            if (Input.GetKeyDown("left")){
                mov = 1;
            }
            if (Input.GetKeyDown("right")){
                mov = 2;
            }
        
            if (Input.GetKeyDown("up")){
                mov = 3;
            }
        
            if (Input.GetKeyDown("down")){
                mov = 4;
            }
        }
    }
    public void corrida(byte b)
    {
        acel += b;
    }
    public void choque(bool c)
    {
        gameObject.transform.position = new Vector3(0, 0, 0);
        c = false;
    }
    public void over(bool s)
    {
        if (s == true)
        {
            fofo = false;
        }else if (s == false)
        {
            fofo = true;
            acel = 300;
        }
        
    }
}