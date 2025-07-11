using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class manager : MonoBehaviour
{
    void Start()
    {
        
    }
    
    [SerializeField] 
    private Text myText;
    void Update()
    {
      myText.text = accident.score.ToString (); 
    }
}

