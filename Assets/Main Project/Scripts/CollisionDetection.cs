using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CollisionDetection : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
<<<<<<< HEAD:Assets/Main Project/Scripts/CollisionDetection.cs
        if (other.gameObject.tag == "Trap") {

            
            Destroy(other.gameObject);

        }
        
=======
        if (other.gameObject.tag == "Trap")
        {


            Destroy(other.gameObject);

        }

>>>>>>> main:Assets/MainProject/Scripts/CollisionDetection.cs
    }

}
