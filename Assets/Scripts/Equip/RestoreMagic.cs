using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "RestoreMagic", menuName = "Equip/RestoreMagic")]
public class RestoreMagic : Equip
{
    [SerializeField] float restoreValue;

    public override void Use()
    {
        if (!isCoolDown)
        {
            return;
        }
        player.RestoreMagic(restoreValue);
        isCoolDown = false;
    }
}
