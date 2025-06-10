using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinero : MonoBehaviour
{
    public float playermoney;
    public UImanager uiManager;
  
    public void UpdateMoney  (float amount)
    {
       

        if (playermoney + amount < 0)
        {

        }
        else
        {
            playermoney += amount;
            uiManager.UpdateMoneyUI(playermoney.ToString());
        }

    }
      
}
