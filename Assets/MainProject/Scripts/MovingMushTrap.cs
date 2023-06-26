using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMushTrap : MonoBehaviour
{
    [SerializeField] Transform[] Positions;
    [SerializeField] float objectSpeed;

    Transform nextPos;

    // Start is called before the first frame update
    void Start()
    {
        SelectRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject();
    }

    void SelectRandomPosition()
    {
        int randomIndex = Random.Range(0, Positions.Length);
        nextPos = Positions[randomIndex];
    }

    void MoveGameObject()
    {
        if (transform.position == nextPos.position)
        {
            SelectRandomPosition();
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, nextPos.position, objectSpeed * Time.deltaTime);
        }
    }
}
