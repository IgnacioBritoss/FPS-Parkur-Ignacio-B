using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI contador;
    public TextMesh victoria;
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
        contador.text = "BRITOS COIN " + plata.ToString() + " $";
        contadorvida.text = "Vida " + vida.ToString() + " %";

        if (vida == 0 || vida < 0)
        {
            Debug.Log("No es por ahi");
            SceneManager.LoadScene("tpfinal");
        }

        if (plata == 0 || plata < 0)
        {
            Debug.Log("Ganaste!");
            victoria.text = "Ganaste!!";
        }
    }

    
       
}
