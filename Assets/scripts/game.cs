using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class game : MonoBehaviour
{
    public GameObject games, textgirl, textboy;
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
        bool check = stateinfo.IsName("playgame");
        if ( check == true )
        {
            Debug.Log("game");
            damage -= Time.deltaTime;
        }
        else
        {
            damage = 0.0f;
        }
        
    }


    public void playgame()
    {
       
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = false; 
        animator.SetBool("play",true);
        textboy.SetActive(true);
        textgirl.SetActive(true);
        

        StartCoroutine(wait());
        
        
           
        

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(15f);
        textboy.SetActive(false);
        textgirl.SetActive(false);
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("play",false);
       
        
    }

    
}
