using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionDetection : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trap") {

            print("Carp�sma");
            Destroy(other.gameObject);

        }
        
    }

}
