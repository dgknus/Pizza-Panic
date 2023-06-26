using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
    public class PlayerMovement : MonoBehaviour
    {
        public CharacterController controller;

        public Timer timer;

        public float speed = 0.6f;
        public float gravity = -15f;

        Vector3 velocity;

        bool isGrounded;
        
        private Keypad keypad;

        private void Start() {
             keypad = FindObjectOfType<Keypad>();
        }
        // Update is called once per frame
        void Update()
        {
            speed = 0.6f;
            speed = speed * timer.pizzaNum;
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);


             // Push to Password Functions with Keyboard
             // Call the Number function in the Keypad script
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                // Code to handle the number 1 key press
                if (keypad != null)
                {
                    keypad.Number(1);
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            { 
                // Code to handle the number 2 key press
                if (keypad != null)
                {
                    keypad.Number(2);
                }
            }
             if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                // Code to handle the number 3 key press
                if (keypad != null)
                {
                    keypad.Number(3);
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            { 
                // Code to handle the number 4 key press
                if (keypad != null)
                {
                    keypad.Number(4);
                }
            }
             if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                // Code to handle the number 5 key press
                if (keypad != null)
                {
                    keypad.Number(5);
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            { 
                // Code to handle the number 6 key press
                if (keypad != null)
                {
                    keypad.Number(6);
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha7))
            { 
                // Code to handle the number 7 key press
                if (keypad != null)
                {
                    keypad.Number(7);
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha8))
            { 
                // Code to handle the number 8 key press
                if (keypad != null)
                {
                    keypad.Number(8);
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha9))
            { 
                // Code to handle the number 9 key press
                if (keypad != null)
                {
                    keypad.Number(9);
                }
            }
            if (Input.GetKeyDown(KeyCode.Alpha0))
            { 
                // Code to handle the number 0 key press
                if (keypad != null)
                {
                    keypad.Number(0);
                }
            }
            if (Input.GetKeyDown(KeyCode.Return))
            { 
                // Code to handle the number Enter key press
                if (keypad != null)
                {
                    keypad.Execute();
                }
            }

         
        }
    }
}