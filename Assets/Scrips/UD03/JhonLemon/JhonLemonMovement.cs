using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JhonLemonMovement : MonoBehaviour
{

    //Zona de variables globales
    [Header("Movement")]
    [SerializeField]
    private float _speed,
                  _turnSpeed;
    [SerializeField]
    private Vector3 _direction;

    //Se guarda la direccion de movimiento
    private Rigidbody _rb;
    private Animator _anim;
    private AudioSource _audioSource;
    private float _horizontal,
                  _vertical;


    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _anim = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {

        Rotation();

    }
    private void OnAnimatorMove()
    {
        _rb.MovePosition(transform.position + (_direction * _anim.deltaPosition.magnitude));
    }

    // Update is called once per frame
    void Update()
    {
        InputsPlayer();
        IsAnimate();
        AudioSteps();
    }


    private void InputsPlayer()
    {
        //Teclas A y D, y < >
        _horizontal = Input.GetAxis("Horizontal");
        //Teclas W y S, y /\ y \/
        _vertical = Input.GetAxis("Vertical");
        //Vector3.forward, Vector3.right, Vector3.left...new Vector3.(x, y, z)
        _direction = new Vector3(_horizontal, 0.0f, _vertical);
        //Normalizar
        _direction.Normalize();
    }

    private void IsAnimate()
    {
        if (_horizontal != 0.0f || _vertical != 0.0f)
        {

            _anim.SetBool("IsWalking", true);

        }
        else
        {

            _anim.SetBool("IsWalking", false);

        }
        
    }
    private void Rotation()
    {

        Vector3 desiredFordward = Vector3.RotateTowards(transform.forward, _direction, _turnSpeed * Time.deltaTime, 0.0f);
        Quaternion rotation = Quaternion.LookRotation(desiredFordward);
        _rb.MoveRotation(rotation);
    }

    private void AudioSteps()
    {
        if (_horizontal != 0.00f || _vertical != 0.00f)
        {
            if(_audioSource.isPlaying == false )
            {
                _audioSource.Play();
            }
            
        }
        else
        {
            _audioSource.Stop();
        }
    
    
    }   
    
}

