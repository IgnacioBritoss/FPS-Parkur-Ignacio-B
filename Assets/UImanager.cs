using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI contador;
    public TextMeshProUGUI contadorvida;
    public dinero dinero;
    public vidamanager vidamanager;
    float plata;
    float vida;

    private void Start()
    {
        dinero = FindObjectOfType<dinero>();
        vidamanager = FindObjectOfType<vidamanager>();
    }

    private void Update()
    {
        plata = dinero.playermoney;
        vida = vidamanager.playervida;
        contador.text = "Plata" + plata.ToString();
        contadorvida.text = "vida:" + vida.ToString();

    }

}
