using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PlayerStateMachine : StateMachine
{
    [SerializeField] PlayerState[] states;
    Animator animator;
    Animator childAnimator;
    PlayerInput input;
    PlayerController player;
    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        childAnimator = GetComponentInChildren<Animator>();
        input = GetComponent<PlayerInput>();
        // stateTable = new Dictionary<System.Type, IState>(states.Length);
        stateTable1 = new Dictionary<String, IState>(states.Length);
        player = GetComponent<PlayerController>();

        foreach (PlayerState state in states)
        {
            state.Initialize(animator, player, input, this);
            // stateTable.Add(state.GetType(), state);
            stateTable1.Add(state.GetType().ToString().Split('_')[1], state);
        }

    }
    void Start()
    {
        // SwitchOn(stateTable[typeof(PlayerState_Idle)]);
        SwitchOn(stateTable1["Idle"]);
    }
    // private void OnGUI()
    // {
    //     GUI.Label(new Rect(0, 0, 100, 100), currentState.ToString());
    // }
}
