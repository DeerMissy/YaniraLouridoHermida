using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    //Zona de variables globales
    [Header("Images")]
    [SerializeField]
    private Image _caughtImage;
    [SerializeField]
    private Image _wonImage;
    [Header("Fade")]
    //La durcuion del fade de la imagen
    //(que va a aparecer poco a poco)
    [SerializeField]
    private float _fadeDuration;
    //el total del tiempo de la imagen en pantalla
    [SerializeField]
    private float _displayImageDuration;

    //contador de tiempo
    private float _timer;

    //Para saber si el player a llegado a la salida
    public bool IsPlayerAtExist;
    //Para saber si an pillado al player
    public bool IsPlayerCaught;
    //Reset o no
    public bool IsRestaerLevel;

    [Header("Audio")]
    [SerializeField]
    private AudioClip _caughtClip;
    [SerializeField]
    private AudioClip _wonClip;
    private AudioSource _audioSource;

    [SerializeField]
    private GameObject _button;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _button.SetActive(false);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (IsPlayerAtExist)
        {
            Won();

        }
        else if (IsPlayerCaught)
        {
            Caught();
        }
    
    }

    private void OnTriggerEnter(Collider infoAcces)
    {
        if (infoAcces.CompareTag("JhonLemon"))
        {

            Debug.Log("He ganado");
         

        }




    }

    public void Retry()
    {
        SceneManager.LoadScene("JhonLemon");
    }
    private void Won()
    {
        _button.SetActive (true);   
        _audioSource.clip = _wonClip;
        if(_audioSource.isPlaying == false)
        {

            _audioSource.Play();


        }

        _timer = _timer + Time.deltaTime; //timer
        //Aumentar el canal alfa de la imagen
        _wonImage.color = new Color(_wonImage.color.r, _wonImage.color.g, _wonImage.color.b, _timer/ _fadeDuration);

        //La imagen se queda durabtw x tiempo
        if (_timer > _fadeDuration + _displayImageDuration)
        {

            Debug.Log("He ganado");
            
        }



    }


    private void Caught()
    {
        _audioSource.clip = _caughtClip;
        if (_audioSource.isPlaying == false)
        {

            _audioSource.Play();


        }

        _timer = _timer + Time.deltaTime; //timer
        //Aumentar el canal alfa de la imagen
        _caughtImage.color = new Color(_caughtImage.color.r, _caughtImage.color.g, _caughtImage.color.b, _timer / _fadeDuration);

        //La imagen se queda durabtw x tiempo
        if (_timer > _fadeDuration + _displayImageDuration)
        {

            Debug.Log("He perdido");
            SceneManager.LoadScene("JhonLemon");
        }



    }




}
