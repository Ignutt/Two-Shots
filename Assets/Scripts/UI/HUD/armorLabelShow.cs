using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class armorLabelShow : MonoBehaviour
{
    public ArmorPoint armor;
    public Text str;

    private void Start()
    {
        str.text = armor.Armor.ToString();
    }

    private void Update()
    {
        str.text = Mathf.Round(armor.Armor).ToString();
    }
}
