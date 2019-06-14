using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armorBarShow : MonoBehaviour
{
    public ArmorPoint armor;
    RectTransform rc;

    Vector2 v2;
    private void Start()
    {
        rc = GetComponent<RectTransform>();
        v2.Set(
            armor.Armor * 2.5f, rc.sizeDelta.y
        );
        rc.sizeDelta = v2;
    }

    private void Update()
    {
        v2.Set(
            armor.Armor * 2.5f, rc.sizeDelta.y
        );
        rc.sizeDelta = v2;
    }


}
