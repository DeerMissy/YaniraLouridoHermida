using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThreeTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       //Llamamos a la funci�n que mostrar� los m�ltiplos de 2 y 3
        MostrarMultiplosDe2y3();
    }

    // Funci�n para mostrar los m�ltiplos de 2 y 3 entre 0 y 100
    void MostrarMultiplosDe2y3()
    {
        Debug.Log("M�ltiplos de 2 y de 3 entre 0 y 100:");

        // Recorremos los n�meros del 0 al 100
        for (int i = 0; i <= 100; i++)
        {
            // Si el n�mero es m�ltiplo de 2 Y de 3 (divisible por ambos), lo mostramos en la consola
            if (i % 2 == 0 && i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}