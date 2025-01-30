using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowJhonLemon : MonoBehaviour
{

    //Zona de variables globales
    public Transform Target;
    [Header("Vectors")]
    //Velocidad de la cámara
    [SerializeField]
    private float _smoothing;
    //Distancia inicial desde la cámara al player
    [SerializeField]
    private Vector3 _offset;


    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - Target.position;
    }

    private void LateUpdate()
    {
        //Posición a la que queremos mover la cámara
        Vector3 desiredPosition = Target.position + _offset;

        //Movemos la cámara
        transform.position = Vector3.Lerp(transform.position, desiredPosition, _smoothing * Time.deltaTime);
    }
}
