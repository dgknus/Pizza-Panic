using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawer : MonoBehaviour
{
    public float openSpeed = 2f; // Speed at which the drawer opens
    public Vector3 openPosition; // Target position when the drawer is fully open
    public Vector3 closedPosition; // Initial position of the drawer when closed

    private bool isOpen = false; // Flag to track if the drawer is currently open
    private bool isMoving = false; // Flag to track if the drawer is currently moving
    // Start is called before the first frame update
    void Start()
    {
        closedPosition = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        // Check for user input to open/close the drawer
        if (Input.GetKeyDown(KeyCode.O) && !isMoving)
        {
            // Toggle the isOpen flag
            isOpen = !isOpen;

            // Calculate the target position based on the current state
            Vector3 targetPosition = isOpen ? openPosition : closedPosition;

            // Start the coroutine to move the drawer
            StartCoroutine(MoveDrawer(targetPosition));
        }
    }
    IEnumerator MoveDrawer(Vector3 targetPosition)
    {
        isMoving = true;

        // Calculate the distance between the current position and the target position
        float distance = Vector3.Distance(transform.localPosition, targetPosition);

        while (distance > 0.01f)
        {
            // Move the drawer towards the target position
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, openSpeed * Time.deltaTime);

            // Update the distance
            distance = Vector3.Distance(transform.localPosition, targetPosition);

            yield return null;
        }

        isMoving = false;
    }
}
