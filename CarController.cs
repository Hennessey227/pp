using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public FixedJoystick Joystick;
    Rigidbody2D rb;
    Vector2 move;
    public float moveSpeed;
    public shooting ProjectilePrefab;
    public Transform LaunchOffset;

    private void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update ()
    {
        move.x = Joystick.Horizontal;
        move.y = Joystick.Vertical;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }


    }

    private void FixedUpdate ()
    {
        rb.MovePosition (rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
