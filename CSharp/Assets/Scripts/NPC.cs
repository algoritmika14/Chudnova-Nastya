using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    public int health = 5;
    public int level = 1;
    public float speed = 1.5f;
    
    void Start()
    {
        health = health + level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
