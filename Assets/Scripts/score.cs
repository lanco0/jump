using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    public int scores=-1;
    public TMP_Text scoreText;
    public Rigidbody player,player2;
    float hiz;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision player)
    {
        scores++;
        scoreText.SetText(scores.ToString());
    }
}
