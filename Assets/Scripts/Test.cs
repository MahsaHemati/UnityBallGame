using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    void Update()
    {
       float h = Input.GetAxisRaw("Horizontal"); 
       float v = Input.GetAxisRaw("Vertical");
       ///ashkan
       gameObject.transform.position =
       new Vector2(transform.position.x + (h*Speed),
       transform.position.y + (v*Speed));
    }
}