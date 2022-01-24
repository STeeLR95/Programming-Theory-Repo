using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    protected override int Number { get { return 2; } }
    protected override string Ammo { get { return "12-Gauge Shotgun Shell"; } }

    protected override void Reload(int number, string ammo)
    {
        
    }
}
