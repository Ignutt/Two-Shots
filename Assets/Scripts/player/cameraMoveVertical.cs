using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMoveVertical : MonoBehaviour
{
    public float sensitivity = 10;


    void Start()
    {
    }

    void Update()
    {
        transform.Rotate(Input.GetAxis("Mouse Y") * -1 * sensitivity, 0, 0);
    }
}
