using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
  
    public float timer = 30.0f;
    public AudioClip miao; 
    private AudioSource  source;  

    private Animator animator; 

    public float damage;
   
    


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

            damage -= Time.deltaTime ;

          

        }      
    }

   

    public void lu()
    {
        animator.SetBool("lu",true);
        StartCoroutine(wait());
        damage = 0.0f;
     

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(20f);
        animator.SetBool("lu",false);
        
    }
   
}
