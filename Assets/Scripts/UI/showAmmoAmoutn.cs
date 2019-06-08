using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    public ammoPlayer ammo;
    UnityEngine.UI.Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Ammo: " + ammo.ammo.ToString() + "/ " + ammo.allAmmo.ToString();

    }
}
