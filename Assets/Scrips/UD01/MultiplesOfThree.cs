using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Llamamos a la funci�n que mostrar� los m�ltiplos de 3
        MostrarMultiplosDe3();
    }

    // Funci�n para mostrar los m�ltiplos de 3 entre 0 y 100
    void MostrarMultiplosDe3()
    {
        Debug.Log("M�ltiplos de 3 entre 0 y 100:");

        // Recorremos los n�meros del 0 al 100
        for (int i = 0; i <= 100; i++)
        {
            // Si el n�mero es m�ltiplo de 3 (divisible por 3), lo mostramos en la consola
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
