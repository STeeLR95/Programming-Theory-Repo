using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Weapon
{
    protected TextMeshProUGUI InfoText = GameObject.Find("OutputText").GetComponent<TextMeshProUGUI>();
    protected TextMeshProUGUI ParentText = GameObject.Find("WeaponText").GetComponent<TextMeshProUGUI>();

    public abstract int Number { get; }
    public abstract string Ammo { get; }

    public abstract TextMeshProUGUI MyText { get; }

    public abstract void Reload(int number, string ammo);

}
