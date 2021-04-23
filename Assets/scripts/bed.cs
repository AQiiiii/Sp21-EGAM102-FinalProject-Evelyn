using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed : MonoBehaviour
{
    // public GameObject bed;
    // public GameObject playerB;
    // public float damage;
    // private Animator animator; 

    // // Start is called before the first frame update
    // void Start()
    // {
    //     animator = GetComponent<Animator>();
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
    //     AnimatorStateInfo stateinfo = animator.GetCurrentAnimatorStateInfo(0); 
    //     bool check = stateinfo.IsName("playgame");
    //     if ( check == true )
    //     {
    //         Debug.Log("game");
    //         damage -= Time.deltaTime;
    //     }
    //     else
    //     {
    //         damage = 0.0f;
    //     }
        
    // }


    // public void playgame()
    // {
       
    //     GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = false; 
        
    //     animator.SetBool("play",true);
    //     StartCoroutine(wait());

    // }

    // private IEnumerator wait()
    // {
        
    //     yield return new WaitForSeconds(15f);
        
    //     GameObject.Find("B").GetComponent<SpriteRenderer>().enabled = true;
    //     animator.SetBool("play",false);
       
        
    // }

}
