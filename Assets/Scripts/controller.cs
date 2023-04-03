using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class controller : MonoBehaviour
{
    public float hiz;
    public Rigidbody karakter;
    public bool ground;
    public Animator anim,anim2;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)&& ground==true)
        {
            karakter.AddForce(Vector3.up * hiz*Time.deltaTime);
            anim.SetTrigger("jump");
            ground = false;
            
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            ground = true;
        }
        
    }
}
