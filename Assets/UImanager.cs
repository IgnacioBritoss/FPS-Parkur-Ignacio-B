using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI TxtMoney;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void UpdateMoneyUI(string moneyAmount)
    {
        TxtMoney.text = moneyAmount;
    }
}
