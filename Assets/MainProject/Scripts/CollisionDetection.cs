using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionDetection : MonoBehaviour
{

    public int k = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Trap")
        {
            if(k > -3)
            {

                //this.k--;

            }

        }

    }

}
