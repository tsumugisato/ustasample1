using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class ColorChange : MonoBehaviour
{
 
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }
 
   void OnMouseDown()
    {
        if(GetComponent<Renderer>().material.color == Color.green)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}
