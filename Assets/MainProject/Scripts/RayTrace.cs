using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTrace : MonoBehaviour
{

    [SerializeField] string targetObject;
    [SerializeField] GameObject passwordPanel; 
    public Camera camera;

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ViewportPointToRay(new Vector3(0.5f,0.5f,0f));
        RaycastHit raycasthit;

        if(Physics.Raycast(ray, out raycasthit) ){

            if(Input.GetMouseButtonDown(0)){

                if(raycasthit.transform.name == targetObject){
                    passwordPanel.SetActive(true);

                }
            }




        }
    }
}