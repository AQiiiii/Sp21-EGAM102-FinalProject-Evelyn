using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tv : MonoBehaviour
{
    
    public GameObject tvs, textgirl, textboy;
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
        bool check = stateinfo.IsName("watchtv");
        if ( check == true )
        {
            Debug.Log("tv");
            damage -= Time.deltaTime;
        }
        else
        {
            damage = 0.0f;
        }
        
    }


    public void watchtv()
    {
       
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = false; 
        
        animator.SetBool("watchtv",true);

        textboy.SetActive(true);
        textgirl.SetActive(true);

        StartCoroutine(wait());

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(15f);
        textboy.SetActive(false);
        textgirl.SetActive(false);
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("watchtv",false);
       
        
    }
}
