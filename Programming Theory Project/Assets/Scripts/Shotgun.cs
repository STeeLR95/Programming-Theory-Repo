using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shotgun : Weapon
{
    public override int Number { get { return 2; } }
    public override string Ammo { get { return "12-Gauge Shotgun Shell"; } }

    public override TextMeshProUGUI MyText { get { return GameObject.Find("ShotgunText").GetComponent<TextMeshProUGUI>(); } }

    public override void Reload(int number, string ammo)
    {
        InfoText.text = $"Reloaded {number} Bullets with {ammo}";
        MyText.color = Color.green;
        ParentText.color = MyText.color;
    }
}
