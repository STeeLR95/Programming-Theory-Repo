using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Weapon : MonoBehaviour
{
    protected TextMeshProUGUI m_InfoText = GameObject.Find("OutputText").GetComponent<TextMeshProUGUI>();

    protected abstract int Number { get; }
    protected abstract string Ammo { get; }

    protected abstract void Reload(int number, string ammo);

}
