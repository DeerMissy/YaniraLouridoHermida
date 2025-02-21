using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasingOrder : MonoBehaviour
{
    // Variables para almacenar los n�meros
    public int numero1;
    public int numero2;
    public int numero3;

    // Start is called before the first frame update
    void Start()
    {
        // Verificar si los n�meros est�n en orden creciente
        if (EsCreciente(numero1, numero2, numero3))
        {
            Debug.Log("Los n�meros est�n en orden creciente.");
        }
        else
        {
            Debug.Log("Los n�meros NO est�n en orden creciente.");
        }
    }

    // Funci�n para comprobar si los n�meros est�n en orden creciente
    bool EsCreciente(int n1, int n2, int n3)
    {
        return n1 < n2 && n2 < n3;
    }
}
    

    

