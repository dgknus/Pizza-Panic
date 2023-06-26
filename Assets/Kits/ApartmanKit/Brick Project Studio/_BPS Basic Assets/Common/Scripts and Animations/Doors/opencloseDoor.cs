using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;
        [SerializeField] bool locked;

        [SerializeField] CubeOrderPuzzle cop;

		// Reference to the Keypad script
       public Keypad keypad;


		void Start()
		{
			open = false;

			 // Assign the Keypad script reference
            keypad = FindObjectOfType<Keypad>();
		}

		void OnMouseOver()
		{
			{
				if (Player)
				{
					float dist = Vector3.Distance(Player.position, transform.position);
					if (dist < 15)
					{
						if(locked && cop.inOrder)
						{
							locked = false;
						}

						if (open == false && !locked)
						{	
							 if (gameObject.name == "Door.L" || gameObject.name == "Door.R") // Added condition to check object name
                        {
								// Check the code from the Keypad script
                            if (keypad != null && keypad.Answer == keypad.Ans.text)
                            {	
								print("Open with password");
								keypad.Execute(); // Call the Execute() method in Keypad script
                                StartCoroutine(opening());
                            }
							
						}
							else if (Input.GetMouseButtonDown(0))
								{
									StartCoroutine(opening());
								}
					
						}
						else
						{
							if (open == true)
							{
								if (Input.GetMouseButtonDown(0))
								{
									StartCoroutine(closing());
								}
							}

						}

					}
				}

			}

		}

		IEnumerator opening()
		{
			print("you are opening the door");
			openandclose.Play("Opening");
			open = true;
			yield return new WaitForSeconds(.5f);
		}

		IEnumerator closing()
		{
			print("you are closing the door");
			openandclose.Play("Closing");
			open = false;
			yield return new WaitForSeconds(.5f);
		}


	}
}