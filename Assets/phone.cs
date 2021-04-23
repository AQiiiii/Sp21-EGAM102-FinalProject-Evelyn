using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phone : MonoBehaviour
{
    public GameObject phoneobject;
    public GameObject playerA, textgirl, textboy;
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
        bool check = stateinfo.IsName("phone");
        if ( check == false )
        {
            
            Debug.Log("phone");
            damage -= Time.deltaTime;
        }
        else
        {
            damage = 0.0f;
        }
        
    }


    public void ringphone()
    {
       
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = false; 
        animator.SetBool("phone",true);
        textgirl.SetActive(true);
        
       
        StartCoroutine(wait());

    }

    public void ringphoneboy()
    {
       
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = false; 
        animator.SetBool("phoneboy",true);
        textboy.SetActive(true);
        
        StartCoroutine(waitboy());

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(10f);
        
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("phone",false);
        textgirl.SetActive(false);
       
        
    }

    private IEnumerator waitboy()
    {
        
        yield return new WaitForSeconds(10f);
        
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("phoneboy",false); 
        textboy.SetActive(false);
        
    }
}
