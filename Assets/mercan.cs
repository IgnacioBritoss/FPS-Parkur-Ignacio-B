﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mercan : MonoBehaviour
{
    public int precio = 10;
    public dinero dinero;


    void Start()
    {
        dinero = FindObjectOfType<dinero>();

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (dinero.UpdateMoney(-precio) == true)
            {
                Destroy(gameObject);
            }
            else { }
        }

    }
}
