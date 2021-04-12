using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementb : MonoBehaviour
{
    
    public float speed;
    private Rigidbody2D myRigidbody; 
    private Vector3 change;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;
        change.x = Input.GetAxisRaw("Horizontal2");
        change.y = Input.GetAxisRaw("Vertical2");
        if(change != Vector3.zero)
        {
            MoveCharacter();
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }
 
    
}
