using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    protected override int Number { get { return 16; } }

    protected override string Ammo { get { return "9mm Pistol Ammo"; } }

    protected override void Reload(int number, string ammo)
    {
        
    }
}
