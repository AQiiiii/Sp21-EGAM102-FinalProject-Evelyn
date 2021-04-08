using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb; 
    Vector2 movement2;

    // Update is called once per frame
    void Update()
    {
        movement2.x = Input.GetAxisRaw("Horizontal");
        movement2.y = Input.GetAxisRaw("Vertical");

    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement2 * moveSpeed * Time.fixedDeltaTime);
    }
}
