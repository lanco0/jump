using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ipvurma : MonoBehaviour
{

    public Rigidbody player;
    // Start is called before the first frame update
    //float vurma=15f;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            //player.AddForce(Vector3.up*vurma);
            //Debug.Log("vurdu");

        }
       
    }
}
