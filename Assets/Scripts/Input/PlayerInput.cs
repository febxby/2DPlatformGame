using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    InputActions inputAction;
    Vector2 axis => inputAction.Gameplay.Axis.ReadValue<Vector2>();
    public bool Jump => inputAction.Gameplay.Jump.WasPressedThisFrame();
    public bool StopJump => inputAction.Gameplay.Jump.WasReleasedThisFrame();
    public bool isJumping => inputAction.Gameplay.Jump.IsPressed();
    public bool openBag => inputAction.Gameplay.Bag.WasPressedThisFrame();
    public bool closeBag => inputAction.Bag.Close.WasPressedThisFrame();
    public bool isAttack => inputAction.Gameplay.Attack.WasPressedThisFrame();
    public bool isSkill1 => inputAction.Gameplay.Skill1.WasPressedThisFrame();
    public bool isUseItem => inputAction.Gameplay.Item.WasPressedThisFrame();
    public bool openInstruction => inputAction.Gameplay.Instruction.WasPressedThisFrame();
    public bool closeInstruction => inputAction.Instruction.Close.WasPressedThisFrame();
    public bool isExit => inputAction.Gameplay.Exit.WasPressedThisFrame();
    Vector2 select => inputAction.Bag.Click.ReadValue<Vector2>();
    public float AxisX => axis.x;
    public bool Move => AxisX != 0;
    public bool hasJumpInputBuffer { get; set; }
    private void Awake()
    {
        inputAction = new InputActions();
    }
    public void EnableGameplayInput()
    {
        inputAction.Gameplay.Enable();
    }
    public void EnableBagInput()
    {
        inputAction.Bag.Enable();
    }
    public void DisableGameplayInput()
    {
        inputAction.Gameplay.Disable();
    }
    public void DisableBagInput()
    {
        inputAction.Bag.Disable();
    }
    public void EnableInstructionInput()
    {
        inputAction.Instruction.Enable();
    }
    public void DisableInstructionInput()
    {
        inputAction.Instruction.Disable();
    }
    // void OnGUI()
    // {
    //     Rect rect = new Rect(0, 0, 200, 200);
    //     string message = "hasJumpInputBuffer:" + hasJumpInputBuffer + "\n" +
    //         "AxisX:" + AxisX + "\n" +
    //         "Move:" + Move + "\n" +
    //         "isJumping:" + isJumping + "\n";
    //     GUIStyle style = new GUIStyle();
    //     style.fontSize = 20;
    //     style.fontStyle = FontStyle.Bold;
    //     GUI.Label(rect, message, style);
    // }
}
