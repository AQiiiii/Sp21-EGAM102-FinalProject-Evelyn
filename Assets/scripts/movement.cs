using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed;
    private Rigidbody2D myRigidbody; 
    private Vector3 change;
    private Animator animator;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        UpdateAnimationAndMove();
        if(Input.GetButtonDown("qpick"))
        {
            StartCoroutine(pickco());
        }
        
    }

     private IEnumerator pickco()
    {
        animator.SetBool("hand",true);
        yield return null;
        animator.SetBool("hand",false);
        yield return new WaitForSeconds(.3f);
    }

    void UpdateAnimationAndMove()
    {
         if(change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving",true);
        }
        else
        {
            animator.SetBool("moving",false);
        }
    }

    void MoveCharacter()
    {
        myRigidbody.MovePosition(transform.position + change * speed * Time.deltaTime);
    }

}
