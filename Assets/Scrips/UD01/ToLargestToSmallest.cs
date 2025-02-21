using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ToLargestToSmallest : MonoBehaviour
{
    // Primero creo una variable
    public int One, Two, Three;
    public int smallest, middle, largest;

    // Start is called before the first frame update
    void Start()
    {
        GetNumber();
    }

    private void GetNumber()
    {
        //Primera posibilidad 
        if (One < Two && One < Three)
        {
            if (Two < Three)



                if (One <= Two && One <= Three)
                {
                    smallest = One;
                    if (Two <= Three)
                    {
                        middle = Two;
                        largest = Three;
                    }
                    else
                    {
                        middle = Three;
                        largest = Two;
                    }
                }
                else if (Two <= One && Two <= Three)
                {
                    smallest = Two;
                    if (One <= Three)
                    {
                        middle = One;
                        largest = Three;
                    }
                    else
                    {
                        middle = Three;
                        largest = One;
                    }
                }
                else
                {
                    smallest = Three;
                    if (One <= Two)
                    {
                        middle = One;
                        largest = Two;
                    }
                    else
                    {
                        middle = Two;
                        largest = One;
                    }
                }

            // Mostrar los números ordenados en la consola
            Debug.Log("Números ordenados de menor a mayor: " + largest + ", " + middle + ", " + largest);
        }
    }
}

