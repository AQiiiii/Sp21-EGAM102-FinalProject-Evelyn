using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat : MonoBehaviour
{
  
    public float timer = 30.0f;
    public AudioClip miao; 
    

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
            
            animator.SetBool("timer",true);

            damage -= Time.deltaTime ;

        }      
    }

   

    public void lu()
    {
        damage = 0.0f;
        animator.SetBool("lu",true);
       
        StartCoroutine(wait());
        
     

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(20f);
        animator.SetBool("lu",false);
        
    }
   
}
