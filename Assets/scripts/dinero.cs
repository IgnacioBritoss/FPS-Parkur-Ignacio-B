﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinero : MonoBehaviour
{
    public float playermoney;
    
  
    public bool UpdateMoney(float amount)
    {
        if(playermoney + amount < 0)
        {
            return false;
        }
        else
        {
            playermoney += amount;
            return true;
        }
    }
}
