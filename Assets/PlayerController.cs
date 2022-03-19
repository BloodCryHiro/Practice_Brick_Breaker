using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 velocity;
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, 0f);
    }

    private void FixedUpdate()
    {
        rb.velocity = velocity;
    }
}
