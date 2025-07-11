using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void Start()
    {
        
    }
[SerializeField]
private KeyCode KeyToDestroy;
    void Update()
    {
     if (Input.GetKeyDown(KeyToDestroy)){
     Destroy(gameObject);   }
    }
}