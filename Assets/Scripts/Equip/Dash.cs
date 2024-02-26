using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Dash", menuName = "Equip/Dash")]
public class Dash : Equip
{
    [SerializeField] float dashForce;
    public override void Use()
    {
        playerController.SetVelocityX(dashForce * playerController.flipX);
    }
}
