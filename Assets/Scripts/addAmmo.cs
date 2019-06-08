using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addAmmo : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
            Destroy(gameObject);
            ammoPlayer a = other.GetComponent<ammoPlayer>();
            if (a) a.add();
    }
}
