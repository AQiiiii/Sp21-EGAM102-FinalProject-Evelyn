using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class letter : MonoBehaviour
{
    public GameObject textgirl;
    public GameObject textboy;
    

    public GameObject letterobject;
    public GameObject playerA;
    public GameObject playerB;
    private Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void girlloveletter()
    {
       
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = false; 
        animator.SetBool("loveletter", true);
        textgirl.SetActive(true);
        StartCoroutine(girlwait());

    }

    public void boyloveletter()
    {
       
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = false; 
        animator.SetBool("loveletter",true);
        textboy.SetActive(true);
        StartCoroutine(boywait());

    }

    private IEnumerator girlwait()
    {
        
        yield return new WaitForSeconds(10f);
        textgirl.SetActive(false);
        GameObject.Find("A").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("loveletter",false);  
        
    }

    private IEnumerator boywait()
    {
        
        yield return new WaitForSeconds(10f);
        textboy.SetActive(false);
        GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = true;
        animator.SetBool("loveletter",false);  
        
    }

  

}
