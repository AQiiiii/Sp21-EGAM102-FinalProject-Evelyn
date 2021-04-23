using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleepa : MonoBehaviour
{
    public GameObject sleepaa;
    public GameObject playerA;
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
        bool check = stateinfo.IsName("sleepa");
        if ( check == true )
        {
            Debug.Log("sleepa");
            damage -= Time.deltaTime;
        }
        else
        {
            damage = 0.0f;
        }
        
    }


    public void girlsleep()
    {
       
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = false; 
        
        animator.SetBool("sleepa",true);
        StartCoroutine(wait());

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(15f);
        
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("sleepa",false);
       
        
    }
}
