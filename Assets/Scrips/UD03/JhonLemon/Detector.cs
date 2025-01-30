using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Detector : MonoBehaviour
{
    //Zona de variables globales
    public GameManager GameManagerScript;
    private void OnTriggerEnter(Collider infoAcces)
    {
        if (infoAcces.CompareTag ("JhonLemon"))
        {

            Debug.Log("Te he pilladooooo");

            GameManagerScript.IsPlayerCaught = true;
        }




    }

    
}
