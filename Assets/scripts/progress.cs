using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class progress : MonoBehaviour
{
    public float a;
    public Text healthText ;
    public float HealthCurrent;
    public int HealthMax;
    private Image healthbar;

    public float damage2; 
    public float damage3; 
    public float damage4;
    public float damage5;
    public float damage6;
    public float damage7;
    public float damage8;
    public GameObject cat;
    public GameObject game;
    public GameObject tv;
    public GameObject bed;
    public GameObject phone;
    public GameObject cap;


    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Image>();
        HealthCurrent =  HealthMax;
        a = 0.0005f;

        
    }

    // Update is called once per frame
    void Update()

    {
        damage2= cat.GetComponent<cat>().damage;
        damage3 = game.GetComponent<game>().damage;
        damage4 = tv.GetComponent<tv>().damage;
        damage5 = bed.GetComponent<sleepbed>().damage;
        //damage6 = bed.GetComponent<sleepbed>().damageboy;
        damage7 = phone.GetComponent<phone>().damage;
        damage8 = cap.GetComponent<boil>().damage;

        healthText .text = HealthCurrent.ToString() + "/" + HealthMax.ToString();
        HealthCurrent = HealthCurrent  + damage2 * a + damage3 * a + damage4 * a - damage5 * a  + damage7 * a + damage8 * a;
        healthbar.fillAmount = (float)HealthCurrent / (float)HealthMax;

        if (healthbar.fillAmount == 0)
        {
            SceneManager.LoadScene("2");
        }
    }
}
