using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pistol : Weapon
{
    public override int Number { get { return 16; } }

    public override string Ammo { get { return "9mm Pistol Ammo"; } }

    public override TextMeshProUGUI MyText { get { return GameObject.Find("PistolText").GetComponent<TextMeshProUGUI>(); } }

    public override void Reload(int number, string ammo)
    {
        InfoText.text = $"Reloaded {number} Bullets with {ammo}";
        MyText.color = Color.red;
        ParentText.color = MyText.color;
    }
}
