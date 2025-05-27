using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class me : MonoBehaviour
{
    public int scorePoints;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "player")
        {
            Destroy(gameObject);

        }
    }
   
}
