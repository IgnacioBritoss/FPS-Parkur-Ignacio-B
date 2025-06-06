using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinero : MonoBehaviour
{
    public float playermoney;
    public UiManager uimanager
    public void UpdateMoney  (float amount)
    {
       

        if (playermoney + amount < 0)
        {

        }
        else
        {
            playermoney += amount;
        }

    }
      
}
