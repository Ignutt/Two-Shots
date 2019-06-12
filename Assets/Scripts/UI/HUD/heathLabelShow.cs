using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heathLabelShow : MonoBehaviour
{
    public HealthPoint player;
    public Text str;

    void Awake()
    {
        str.text = Mathf.Round(player.Health).ToString();
    }

    void Update()
    {
        str.text = Mathf.Round(player.Health).ToString();
    }
}
