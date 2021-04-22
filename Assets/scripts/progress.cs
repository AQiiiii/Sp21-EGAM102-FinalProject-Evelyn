using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progress : MonoBehaviour
{
    public float a;
    public Text healthText ;
    public float HealthCurrent;
    public int HealthMax;
    private Image healthbar;

    public float damage2; 
    public GameObject cat;


    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Image>();
        HealthCurrent =  HealthMax;
        a = 0.005f;

        
    }

    // Update is called once per frame
    void Update()

    {
        damage2= cat.GetComponent<cat>().damage;
        
        healthText .text = HealthCurrent.ToString() + "/" + HealthMax.ToString();
        HealthCurrent = HealthCurrent  + damage2 * a   ;
        healthbar.fillAmount = (float)HealthCurrent / (float)HealthMax;
    }
}
