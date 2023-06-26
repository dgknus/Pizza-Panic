using UnityEngine;

public class CubeOrderPuzzle : MonoBehaviour
{
    public GameObject[] cubes;
    public new Camera camera;


    void Start()
    {
        cubes = new GameObject[5];

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

                        break;
                    }
                }
            }
        }
    }
}
