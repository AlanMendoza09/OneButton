using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public KeyCode moveRight;
    public float move = 3.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(moveRight))
        {
            transform.position = new Vector3(transform.position.x + move, -2, 0);
        }
    }
}
