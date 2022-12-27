using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongInput : MonoBehaviour
{
    public GameObject[] WrongObjects;
    public GameObject[] MGdisplay;
    public GameObject error;
    public Lives inc;
    public void wrongclick()
    {
        MGdisplay[inc.inc].SetActive(true);
        Debug.Log("x");
        inc.inc+=1;
        Debug.Log(inc.inc);

        if (inc.inc == 3)
        {
            error.SetActive(true);
        }
    }
   
}
