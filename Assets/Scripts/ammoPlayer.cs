using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoPlayer : MonoBehaviour
{
    public int ammo = 30;
    public int ammoEnemy = 30;
    public int allAmmo = 0;

    public void add()
    {
        allAmmo += ammoEnemy;

        if (allAmmo <= 0) allAmmo = 0;
        if (allAmmo >= 300) allAmmo = 300;
    }
}
