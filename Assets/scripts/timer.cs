using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 60f;
    float timeLeft;
    public GameObject timeUpText;
    // Start is called before the first frame update
    void Start()
    {
        timeUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            timeUpText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
