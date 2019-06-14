using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorPoint : MonoBehaviour
{
    HealthPoint hp;
    public float Armor = 0;
    public bool isArmored()
    {
        if (Armor > 0)
        {
            return true;
        }
        else return false;
    }

    void Update()
    {
        if (isArmored())
        {
            hp.enabled = false;
        }
    }
}
