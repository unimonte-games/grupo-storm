using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour
{
    public int Score = 0;
    public Text ScoreText;
    public GameObject health1;
    public float vida;

    
    // Update is called once per frame
    void Update()
    {
        vida = health1.GetComponent<Health>().health;  
        
        if (vida == 1)
        {
            Score += 1;
            ScoreText.text = Score.ToString();
        }      
    }


}
