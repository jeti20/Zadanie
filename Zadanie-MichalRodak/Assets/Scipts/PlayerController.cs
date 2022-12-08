using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontalInput;
    private float verticalInput;
    private float xRange = 8.4f;
    private float yRange = 4.5f;
    [SerializeField] private float speed = 20f;

    void Update()
    {
        if (transform.position.x < -xRange)
            transform.position = new Vector2(-xRange, transform.position.y);
     
        if (transform.position.x > xRange)
            transform.position = new Vector2(xRange, transform.position.y);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);


        if (transform.position.y < -yRange)
            transform.position = new Vector2(transform.position.x, -yRange);

        if (transform.position.y > yRange)
            transform.position = new Vector2(transform.position.x, yRange);
        
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * verticalInput * Time.deltaTime * speed);
    }
}
