using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AssaultRifle : Weapon
{
    public override int Number { get { return 5; } }

    public override string Ammo { get { return "7.62x51mm Assault Rifle Projectile"; } }

    public override TextMeshProUGUI MyText { get { return GameObject.Find("RifleText").GetComponent<TextMeshProUGUI>(); } }

    public override void Reload(int number, string ammo)
    {
        InfoText.text = $"Reloaded {number} Bullets with {ammo}";
        MyText.color = Color.blue;
        ParentText.color = MyText.color;
    }
}
