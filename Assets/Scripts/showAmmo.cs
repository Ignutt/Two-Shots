using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class showAmmo : MonoBehaviour
    {
        public ammoPlayer ammo;
        UnityEngine.UI.Text textBoxAmmo;

        void Start()
        {
            textBoxAmmo = GetComponent<UnityEngine.UI.Text>();
        }

        void Update()
        {
            textBoxAmmo.text = "Ammo: " + ammo.ammo.ToString() + "/ " + ammo.allAmmo.ToString();
        }
    }
