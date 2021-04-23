using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boil : MonoBehaviour
{
    public float timer = 15.0f;
    public AudioClip boiling; 
    

    private Animator animator; 

    public float damage;
   
    


    // Start is called before the first frame update
    void Start()
    {
        // 开始
        animator = GetComponent<Animator>();
        
       
     
    }


    // 更新
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer<=0f)
        {
            
            animator.SetBool("boiling",true);

            damage -= Time.deltaTime ;

        }      
    }

   

    public void stop()
    {
        damage = 0.0f;
        animator.SetBool("boiling",false);
       

    }

    
   
}
