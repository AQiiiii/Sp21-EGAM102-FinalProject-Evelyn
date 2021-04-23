using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedB : MonoBehaviour
{
    public GameObject sleepbb;
    public GameObject playerB;
    public float damage;
    private Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo stateinfo = animator.GetCurrentAnimatorStateInfo(0); 
        bool check = stateinfo.IsName("bsleep");
        if ( check == true)
        {
            Debug.Log("bsleep");
            damage -= Time.deltaTime;
        }
        else
        {
            damage = 0.0f;
        }
        
    }


    public void sleepbedB()
    {
       
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = false; 
        
        animator.SetBool("bsleep",true);
        StartCoroutine(wait());

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(15f);
        
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("bsleep",false);
       
        
    }
}
