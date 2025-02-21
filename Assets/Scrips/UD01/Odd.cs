using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Llamamos a la funci�n que mostrar� los n�meros impares
        MostrarNumerosImpares();
    }

    // Funci�n para mostrar los n�meros impares entre 0 y 100
    void MostrarNumerosImpares()
    {
        Debug.Log("N�meros impares entre 0 y 100:");

        // Recorremos los n�meros del 0 al 100
        for (int i = 0; i <= 100; i++)
        {
            // Si el n�mero es impar (no divisible por 2), lo mostramos en la consola
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}
    

    

