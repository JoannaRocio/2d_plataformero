using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Para desactivar el objeto pero no lo destruye 
        //gameObject.SetActive(false);
        Destroy(gameObject);

    }
}
