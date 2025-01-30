using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    //Zona variables globales 
    [Header ("WayPoints")]
    //Array de posiciones la patrulla del fantasma
    [SerializeField]
    private Transform[] _positionsArray;
    [SerializeField]
    private float  _speed;
    //Almacenar la posicion a l que dirige el fantasma
    private Vector3 _posToGo;
    //Indice para controlar en la posicion del array
    private int _i;
    private Ray _ray;
    private RaycastHit _hit;

    public GameManager GameManagerScript;





    // Start is called before the first frame update
    void Start()
    {

        _i = 0;
        _posToGo = _positionsArray[_i].position;



    }

    private void FixedUpdate()
    {

        DetectionJhonLemon();


    }

    // Update is called once per frame
    void Update()
    {

        Move();
        ChangePosition();
        Rotate();


    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _posToGo, _speed * Time.deltaTime);
    }

    private void ChangePosition()
    {

        if (Vector3.Distance (transform.position,_posToGo) <= Mathf.Epsilon )
        {
            //Comprobar q estoy en la ultima del array
            //Un array con 2 elementos: el elemento 0 y el elemento 1
            if(_i== _positionsArray.Length - 1)
            {
                //Vuelvo a la casilla inicial del array
                _i = 0;

          
            }
            else
            {
                _i++;//_i = _i + 1;
            }

            _posToGo = _positionsArray[_i].position;

        }   


    }
    private void Rotate()
    {
        transform.LookAt(_posToGo);
    }

    private void DetectionJhonLemon()
    {
        // subir eñ origen del rayo 1m en el eje y con respecto al punto
        // de pivote del objeto
        _ray.origin = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
        _ray.direction = transform.forward;


        if (Physics.Raycast(_ray, out _hit))
        {

            if(_hit.collider.CompareTag("JhonLemon"))
            {

                Debug.Log("Soy el fantasma y te he pillado");
                GameManagerScript.IsPlayerCaught = true;
}


        }
    }


}   
