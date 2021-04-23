using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleepb : MonoBehaviour
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
        bool check = stateinfo.IsName("sleepb");
        if ( check == true )
        {
            Debug.Log("sleepb");
            damage -= Time.deltaTime;
        }
        else
        {
            damage = 0.0f;
        }
        
    }


    public void boysleep()
    {
       
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = false; 
        
        animator.SetBool("sleepb",true);
        StartCoroutine(wait());

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(15f);
        
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("sleepb",false);
       
        
    }
}
