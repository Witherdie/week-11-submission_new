using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float speed;
    public float horizontalInput;
    public float horizontalScreenLimit;
    public float verticalInput;
    public float verticalScreenLimit;

    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
        horizontalScreenLimit = 12f;
        verticalScreenLimit = 1f;
    }

    // Update is called once per frame; if your computer runs at 60 fps
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * speed);
        if (transform.position.x > horizontalScreenLimit)
        {
            transform.position = new Vector3(-horizontalScreenLimit, 0, 0);
        }
        else if (transform.position.x < -horizontalScreenLimit)
        {
            transform.position = new Vector3(horizontalScreenLimit, 0, 0);
        }

        if (transform.position.y > verticalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x, -verticalScreenLimit, 0);
        }
        else if (transform.position.y < -verticalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x, verticalScreenLimit, 0);
        }
    }

}