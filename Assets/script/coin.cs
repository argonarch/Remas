using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public static coin asd;
    public GameObject coinsas;
    void Start() 
    {
        asd = this;
    }
    public void ads(bool facs)
    {
        if (facs == true)
            {
                float x = Random.Range(-300f, 300f);
                float y = Random.Range(-250f, 250f);
                Vector3 position = new Vector3(x, y, 0);
                Quaternion rotate = new Quaternion();
                Instantiate(coinsas, position, rotate);
            }
    }
}
