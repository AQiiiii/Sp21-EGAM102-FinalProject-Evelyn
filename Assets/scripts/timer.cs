using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    Image timerBar;
    public float a;
    public float maxTime = 60f;
    float timeLeft;
   
    void Start()
    {
       
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
     
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime ;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            SceneManager.LoadScene("3");
            Time.timeScale = 0;
        }
    }

    
}
