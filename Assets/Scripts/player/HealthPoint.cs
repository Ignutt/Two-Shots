using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoint : MonoBehaviour
{

    public float Health = 100;
    public Canvas screen;

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
        if (!isAlive())
        {
            screen.enabled = false;
            Destroy(GameObject.Find("Player"));
        }
        if (Health <= 0) Health = 0;
    }
}
