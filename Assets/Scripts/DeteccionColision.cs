using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionColision : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject triguer;
    public GameObject _interactiveObject;
    public GameObject jugador;


    private bool activated = false;


    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider jugador)
    {
        if (jugador != null)
        {
            Debug.Log("Entro");
            if (!activated)
            {

                _interactiveObject.SetActive(true);
                
            }


        }
    }

    //private void OnTriggerExit(Collider jugador)
    //{

    //    if (jugador != null)
    //    {
    //        Debug.Log("Salio");
    //        if (!activated)
    //        {
    //            _interactiveObject.SetActive(false);

    //        }


    //    }


    //   }
    }

//if (other.tag == "Jugador")