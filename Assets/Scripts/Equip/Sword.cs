using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Sword", menuName = "Equip/Sword")]
public class Sword : Equip
{
    public override void Use()
    {
        if (!isCoolDown)
        {
            return;
        }
        equipManager.playerAttack.SwordAttack();
    }
}
