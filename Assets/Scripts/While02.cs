using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While02 : MonoBehaviour
{
    public int num1;
    public int num2;

    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Ambos numeros son iguales");

        }
        else if (num1>=num2) { 
            while (num1 >= num2)
            {
                Debug.Log(num2);
                num2++;
            }
        }
        else { 
        while (num2 >= num1)
            {
                Debug.Log(num1);
                num1++;
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
