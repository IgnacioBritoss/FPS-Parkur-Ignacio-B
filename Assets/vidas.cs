using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidas : MonoBehaviour
{
    public int danio = 10;
    public vidamanager vidamanager;


    void Start()
    {
        vidamanager = FindObjectOfType<vidamanager>();

    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("contact");
        if (collision.gameObject.CompareTag("Player"))
        {
            if (vidamanager.UpdateHealth(-danio) == true)
            {
                Destroy(gameObject);
            }
            else { }
        }

    }
}
