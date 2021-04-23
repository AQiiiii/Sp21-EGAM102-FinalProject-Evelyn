using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    public GameObject dialogBoxA;
    public Text dialogTextA;
    public string dialogA;
    public bool playerInRangeA;

    public GameObject dialogBoxB;
    public Text dialogTextB;
    public string dialogB;
    public bool playerInRangeB;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerInRangeB)
        {
            if(dialogBoxB.activeInHierarchy)
            {
                dialogBoxB.SetActive(false);
            }
            else
            {
                dialogBoxB.SetActive(true);
                dialogTextB.text = dialogB;
            }   
        }
        if(Input.GetKeyDown(KeyCode.O) && playerInRangeA)
        {
            if(dialogBoxA.activeInHierarchy)
            {
                dialogBoxA.SetActive(false);
            }
            else
            {
                dialogBoxA.SetActive(true);
                dialogTextA.text = dialogA;
            } 
        }

      
        
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("PlayerB"))
        {
            playerInRangeB = true;
        }
         if(other.CompareTag("PlayerA"))
        {
            playerInRangeA = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("PlayerA"))
        {
           playerInRangeA = false;
           dialogBoxA.SetActive(false);
        }
        if(other.CompareTag("PlayerB"))
        {
           playerInRangeB = false;
           dialogBoxB.SetActive(false);
        }
    }

}
