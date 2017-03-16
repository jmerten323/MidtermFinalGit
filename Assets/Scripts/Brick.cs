using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int strength = 1;
    public int points = 1;
   
    
    // Use this for initialization
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        strength--;
        
        if (strength == 0) { 

        
        {
                this.gameObject.SetActive(false);
                FindObjectOfType<Ball>().YouBrokeABrick(points);
            }
        }
    }

}

