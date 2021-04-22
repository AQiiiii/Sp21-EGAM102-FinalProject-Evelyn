using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    public GameObject games;
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
        
    }


    public void playgame()
    {
        Debug.Log("game");
        damage -= Time.deltaTime;
        animator.SetBool("play",true);
       
        StartCoroutine(wait());

    }

    private IEnumerator wait()
    {
        
        yield return new WaitForSeconds(10f);
        animator.SetBool("play",false);
        
    }

    
}
