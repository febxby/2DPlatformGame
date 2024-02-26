using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "RestoreHealth", menuName = "Equip/RestoreHealth")]
public class RestoreHealth : Equip
{
    [SerializeField] float restoreValue;

    public override void Use()
    {
        if (!isCoolDown)
        {
            return;
        }
        player.RestoreHealth(restoreValue);
        isCoolDown = false;
    }

}
