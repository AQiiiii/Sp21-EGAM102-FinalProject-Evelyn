using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleepbed : MonoBehaviour
{
    public GameObject bed;
    public GameObject playerA, textgirl, textboy;
    public GameObject playerB;
    public float  damage;
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
        bool check2 = stateinfo.IsName("sleepb");
        if ( check == true)
        {
            damage -= Time.deltaTime;
        }
        if ( check2 == true )
        {
            damage -= Time.deltaTime;
        }
        else
        {
            damage = 0.0f;
        }
        
    }


    public void sleepa()
    {
       
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = false; 
        animator.SetBool("sleepa",true);
        textgirl.SetActive(true);
        
       
        StartCoroutine(wait());

    }

    public void sleepb()
    {
       
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = false; 
        animator.SetBool("sleepb",true);
        textboy.SetActive(true);
        
        StartCoroutine(waitboy());

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(10f);
        
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("sleepa",false);
        textgirl.SetActive(false);
       
        
    }

    private IEnumerator waitboy()
    {
        
        yield return new WaitForSeconds(10f);
        
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("sleepb",false); 
        textboy.SetActive(false);
        
    }
}
