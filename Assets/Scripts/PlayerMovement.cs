using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public KeyCode moveRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(moveRight))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(3, 0, 0);
        }
    }
}
