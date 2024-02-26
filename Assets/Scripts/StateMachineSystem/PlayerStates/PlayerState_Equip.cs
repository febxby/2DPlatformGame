using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "PlayerState_Dash", menuName = "Data/StateMachine/PlayerState/Dash")]
public class PlayerState_Dash : PlayerState
{
    [SerializeField] float dashForce;
    public override void Enter()
    {
        player.AddForce(dashForce * Vector2.right);
    }
    public override void LogicUpdate()
    {
        
    }
    public override void PhysicsUpdate()
    {
    }
}
