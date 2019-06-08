using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{

    public float Health = 100;

    void Start()
    {
        
    }

    public bool isAlive()
    {
        if (Health <= 0)
        {
            return false;
        }
        else return true;
    }

    void Update()
    {

    }
}
