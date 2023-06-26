using UnityEngine;

public class CubeOrderPuzzle : MonoBehaviour
{
    public GameObject[] cubes;
    public string[] cubeNames;
    public Camera camera;
    public bool isBox12 = false; // Bool variable to track if cubes[0] has the name "box12"

    void Start()
    {
        cubes = new GameObject[7];
        cubeNames = new string[7] { "box7", "box21", "box12", "boxx", "box9", "box+", "box/" };

        for (int i = 0; i < transform.childCount; i++)
        {
            cubes[i] = transform.GetChild(i).gameObject;
        }
    }

    void Update()
    {
        Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                for (int i = 0; i < cubes.Length; i++)
                {
                    if (hit.transform.gameObject == cubes[i])
                    {
                        int nextIndex = (i + 1) % cubes.Length;

                        Vector3 tempPosition = cubes[i].transform.position;
                        cubes[i].transform.position = cubes[nextIndex].transform.position;
                        cubes[nextIndex].transform.position = tempPosition;

                        GameObject tempCube = cubes[i];
                        cubes[i] = cubes[nextIndex];
                        cubes[nextIndex] = tempCube;

                        if (i == 0 && cubeNames[i] == "box12")
                        {
                            if (i == 1 && cubeNames[i] == "box+")
                            {
                                if (i == 2 && cubeNames[i] == "box9")
                                {
                                    if (i == 3 && cubeNames[i] == "boxx")
                                    {
                                        if (i == 4 && cubeNames[i] == "box7")
                                        {
                                            if (i == 5 && cubeNames[i] == "box/")
                                            {
                                                if (i == 6 && cubeNames[i] == "box21")
                                                {
                                                    isBox12 = true;
                                                    Debug.Log("cubes[0] has the name 'box12'.");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            isBox12 = false;
                        }

                        break;
                    }
                }
            }
        }
    }
}
