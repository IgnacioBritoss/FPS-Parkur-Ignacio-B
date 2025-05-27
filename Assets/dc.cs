using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dc : MonoBehaviour
{
    void OnColisionEnter(Collision collision)
    {
        Debug.Log("contacto con " + collision.gameObject.name);
        Destroy(collision.gameObject);
    }

  
}
