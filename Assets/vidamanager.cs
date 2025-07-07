using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidamanager : MonoBehaviour
{
    public float playervida;


    public bool UpdateMoney(float amount)
    {
        if (playervida + amount < 0)
        {
            return false;
        }
        else
        {
            playervida += amount;
            return true;
        }
    }
}
