using UnityEngine;

public class CubeOrderPuzzle : MonoBehaviour
{
    public GameObject[] cubes;
    public string[] cubeNames;
    public Camera camera;
    public bool inOrder = false; // Bool variable to track if cubes in order

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

        Debug.Log(inOrder);

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

                        if (cubes[0].name == "box12" && cubes[1].name == "box+" && cubes[2].name == "box9" && cubes[3].name == "boxx" && cubes[4].name == "box7" && cubes[5].name == "box/" && cubes[6].name == "box21")
                        {
                            inOrder = true;
                        }
                        else
                        {
                            inOrder = false;
                        }

                        break;
                    }
                }
            }
        }
    }
}
