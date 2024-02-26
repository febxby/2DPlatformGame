using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "RestorePower", menuName = "Equip/RestorePower")]
public class RestorePower : Equip
{
    [SerializeField] float restoreValue;

    public override void Use()
    {
        // if (!isCoolDown)
        // {
        //     return;
        // }
        player.RestoreMagic(restoreValue);
        player.RestoreHealth(restoreValue);
        isCoolDown = false;
    }
}
