using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ammoShow : MonoBehaviour
{
    public ammo ammo;
    public Text str;

    void Start()
    {
        str.text = ammo.ammoInMagaz.ToString() + " / " + ammo.allAmmo.ToString();
    }

    void Update()
    {
        str.text = ammo.ammoInMagaz.ToString() + " / " + ammo.allAmmo.ToString();
    }
}
