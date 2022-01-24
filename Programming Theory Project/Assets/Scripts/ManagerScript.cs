using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerScript : MonoBehaviour
{
    private Weapon shotg;
    private Weapon pist;
    private Weapon sniper;
    private int selection = 0;
    // Start is called before the first frame update
    void Start()
    {
        shotg = new Shotgun();
        pist = new Pistol();
        sniper = new AssaultRifle();

        InvokeRepeating("ReloadGun", 1, 5);
    }

    private void ReloadGun()
    {
        switch (selection)
        {
            case 0:
                sniper.MyText.color = Color.white;
                pist.Reload(pist.Number, pist.Ammo);
                selection++;
                break;
            case 1:
                pist.MyText.color = Color.white;
                shotg.Reload(shotg.Number, shotg.Ammo);
                selection++;
                break;
            case 2:
                shotg.MyText.color = Color.white;
                sniper.Reload(sniper.Number, sniper.Ammo);
                selection -= selection;
                break;
        }
    }
}
