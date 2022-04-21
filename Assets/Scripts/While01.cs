using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While01 : MonoBehaviour
{
   
    void Start()
    {
        int min = 1;
        int max = 100;
        while (min <= max)
        {
            Debug.Log("Este es el numero "+min);
            min++;
        }
        Debug.Log("Termino el while");
    }
    

   
    void Update()
    {
        
    }
}
