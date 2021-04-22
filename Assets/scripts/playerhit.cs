using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhit : MonoBehaviour
{
    public cat a;
   
    
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("cat"))
        {
            other.GetComponent<cat>().lu();
            a.timer = 20.0f;
        }

        if(other.CompareTag("game"))
        {
            other.GetComponent<game>().playgame();
        }
    }

    
}
