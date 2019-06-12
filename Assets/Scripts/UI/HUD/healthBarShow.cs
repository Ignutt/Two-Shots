using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthBarShow : MonoBehaviour
{
    public HealthPoint player;

    RectTransform reactTrans;

    Vector2 v2;
    void Start()
    {
        reactTrans = GetComponent<RectTransform>();
        v2.Set(player.Health * 2.5f, reactTrans.sizeDelta.y);
        reactTrans.sizeDelta = v2;
    }

    void Update()
    {
        v2.Set(player.Health * 2.5f, reactTrans.sizeDelta.y);
        reactTrans.sizeDelta = v2;
    }
}
