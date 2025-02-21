using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Adittion : MonoBehaviour
{
    [SerializeField]
    private int number;


    // Start is called before the first frame update
    void Start()
    {

        //variable local
        int result = GetAddition(number);
        Debug.Log("La suma de los numeros del 1 al" + number + "es: " + result);


    }

    //Se crea el metodo que sumara del 1 al number
    private int GetAddition(int number)
    {

        //Se crea una variable local para la suma
        int addition = 0;

        //Se crea un bucle que sumara todos los numeros, del 1 al number
        for (int i = 1; i < number; i++)
        {
            addition = addition + i;
        }
        return addition;
    }


}