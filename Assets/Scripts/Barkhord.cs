
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Barkhord : MonoBehaviour
{
    public Text myText;
    public Text scoreText;
    private int score=5;
    private void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag=="Ceil")
        {
            Debug.Log("Score : ");
            score --;
            scoreText.text="Score : " + score;
        }
        if(other.gameObject.tag=="Win"){
            Debug.Log("Barande");
            myText.text="";
            score = score + 10;
            scoreText.text="Score : " + score;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}