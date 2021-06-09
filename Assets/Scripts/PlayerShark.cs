using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShark : MonoBehaviour
{
    private Rigidbody2D _rb;

    private Camera mainCamera;
    private Vector2 movement;
    private Vector2 minScreenBounds;
    private Vector2 maxScreenBounds;

    public float speed;
    public float rotationSpeed;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
        minScreenBounds = mainCamera.ScreenToWorldPoint(new Vector2(0,0));
        maxScreenBounds = mainCamera.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Update()
    {
        Rotate();
    }

    private void LateUpdate()
    {
        EdgeDetection();
    }

    private void Move()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        movement = new Vector2(horizontalInput, verticalInput);

        //_rb.AddForce(movement * speed);
        _rb.velocity = movement * speed * Time.deltaTime;
    }

    private void Rotate()
    {
        float rotAngle = Mathf.Atan2(movement.y, movement.x);
        transform.rotation = Quaternion.Euler(0, 0, rotAngle * Mathf.Rad2Deg);
    }

    private void EdgeDetection()
    {
        Vector2 myPosition = transform.position;
        myPosition.x = Mathf.Clamp(myPosition.x, minScreenBounds.x + 1, maxScreenBounds.x - 1);
        myPosition.y = Mathf.Clamp(myPosition.y, minScreenBounds.y + 1, maxScreenBounds.y - 1);
        transform.position = myPosition;
    }
}
