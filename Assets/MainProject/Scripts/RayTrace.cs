using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTrace : MonoBehaviour
{
    [SerializeField] string targetObject;
    [SerializeField] GameObject passwordPanel;
    public Camera camera;
    private bool isActive = false; // Track the activation state

    void Update()
    {
        Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit raycastHit;

        if (Physics.Raycast(ray, out raycastHit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (raycastHit.transform.name == targetObject)
                {
                    isActive = !isActive; // Toggle the activation state
                    passwordPanel.SetActive(isActive);
                }
            }
        }
    }
}






