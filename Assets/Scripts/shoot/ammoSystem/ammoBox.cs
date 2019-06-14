using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammoBox : MonoBehaviour
{
    public ammo ammo;
    public int ammoBoxGive = 30;

    private void OnTriggerEnter(Collider other)
    {
        ammo = other.GetComponent<ammo>();
        if (ammo)
        {
            ammo.allAmmo += ammoBoxGive;
            GameObject.Destroy(gameObject);
        }
    }
}
