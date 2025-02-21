using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Odd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Llamamos a la función que mostrará los números impares
        MostrarNumerosImpares();
    }

    // Función para mostrar los números impares entre 0 y 100
    void MostrarNumerosImpares()
    {
        Debug.Log("Números impares entre 0 y 100:");

        // Recorremos los números del 0 al 100
        for (int i = 0; i <= 100; i++)
        {
            // Si el número es impar (no divisible por 2), lo mostramos en la consola
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
    }
}
    

    

