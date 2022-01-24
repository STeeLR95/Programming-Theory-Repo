using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultRifle : Weapon
{
    protected override int Number { get { return 5; } }

    protected override string Ammo { get { return "7.62x51mm Assault Rifle Projectile"; } }

    protected override void Reload(int number, string ammo)
    {
        
    }
}
