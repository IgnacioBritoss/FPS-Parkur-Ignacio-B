﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class REstartsceneonfall : MonoBehaviour
{
    public float deathFall = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deathFall )
        {
            Debug.Log("respawn");
            SceneManager.LoadScene("tpfinal");
        }
    }
}
