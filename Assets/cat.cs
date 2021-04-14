using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
    public float timer = 30.0f;
    public AudioClip miao; 
    private AudioSource source;  
    //public GameObject player;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        source = GetComponent<AudioSource>(); 
    
    }


    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0f)
        {
            source.Play();
            
            animator.SetBool("timer",true);
             
            timer = 30.0f;
        }
        
        
        
    }

   
}
