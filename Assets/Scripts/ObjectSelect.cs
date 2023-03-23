using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelect : Interactable
{
    public Transform playerHand;
    public Vector3 offset;

    public bool objetoEnMano = false; // Variable para verificar si el objeto está en la mano del jugador

    public override void Interact()
    {
        base.Interact();

        gameObject.SetActive(false);

        transform.SetParent(playerHand);
        transform.localPosition = offset;
        transform.localRotation = Quaternion.identity;
        transform.localScale = Vector3.one;
        transform.Rotate(Vector3.up * 180);

        gameObject.SetActive(true);

        objetoEnMano = true; // Cambia el valor de objetoEnMano a true
    }
}