using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dc : MonoBehaviour
{
    void OnColisionEnter(Collision collision)
    {
        Debug.Log("bien");
        Destroy(gameObject);
    }

  
}
