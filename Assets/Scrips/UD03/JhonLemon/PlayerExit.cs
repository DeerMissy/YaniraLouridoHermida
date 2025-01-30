using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExit : MonoBehaviour
{
    //Zona de variables globales
    public GameManager GameManagerScript;
    private void OnTriggerEnter(Collider infoAcces)
    {
        if (infoAcces.CompareTag("JhonLemon"))
        {

            GameManagerScript.IsPlayerAtExist = true;

        }




    }
}
