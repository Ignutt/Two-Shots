using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHealthOnScreen : MonoBehaviour
{
    public health hp;
    UnityEngine.UI.Text text;

    void Start()
    {
        text = GetComponent<UnityEngine.UI.Text>();
    }

    void Update()
    {
        text.text = "Health: " + hp.Health.ToString();
    }
}
