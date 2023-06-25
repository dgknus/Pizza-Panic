using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingTrap : MonoBehaviour
{
<<<<<<< HEAD:Assets/Main Project/Scripts/MovingTrap.cs
    public GameObject TrapObj;
    public List<Transform> checkpointPositions;
    public float speed = 1f;
    public int ind = 1;
    // Start is called before the first frame update
    void Start()
    {
        TrapObj.transform.position = checkpointPositions[0].position;
=======
    [SerializeField] Transform[] Positions;
    [SerializeField] float objectSpeed;

    int nextPosIndex;
    Transform nextPos;
    // Start is called before the first frame update
    void Start()
    {
        nextPos = Positions[0];
>>>>>>> main:Assets/MainProject/Scripts/MovingTrap.cs
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD:Assets/Main Project/Scripts/MovingTrap.cs
        TrapObj.transform.position = Vector3.MoveTowards(TrapObj.transform.position, checkpointPositions[ind].position, speed * Time.deltaTime);
        if (Vector3.Distance(TrapObj.transform.position, checkpointPositions[ind].position) <= 0.05f)
        {
            ChangeCheckpoint();

            TrapObj.transform.LookAt(checkpointPositions[ind]);
        }

    }

    public void ChangeCheckpoint()
    {
        if (ind + 1 >= checkpointPositions.Count)
        {
            ind = 0;
        }
        else
        {
            ind++;
        }

    }
}
=======
        MoveGameObject();
    }

    void MoveGameObject()
    {
        if (transform.position == nextPos.position)
        {
            nextPosIndex++;

            if (nextPosIndex >= Positions.Length)
            {
                nextPosIndex = 0;
            }
            nextPos = Positions[nextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPos.position, objectSpeed * Time.deltaTime);
        }
    }
}
>>>>>>> main:Assets/MainProject/Scripts/MovingTrap.cs
