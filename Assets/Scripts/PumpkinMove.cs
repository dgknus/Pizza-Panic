using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpkinMove : MonoBehaviour
{
    public float speed = 3;
    Vector3.forward=(0,0,1);
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movePumpkin(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));     
    }
    void movePumpkin (Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
