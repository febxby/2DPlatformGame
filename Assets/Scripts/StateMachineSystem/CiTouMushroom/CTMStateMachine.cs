using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class CTMStateMachine : StateMachine
{
    [SerializeField] GameObject stateObject;
    public string monsterName;
    Animator animator;
    CTMController monster;
    // Type type;
    CTMState[] states;
    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        monster = GetComponent<CTMController>();
        states = stateObject.GetComponents<CTMState>();
        // stateTable = new Dictionary<System.Type, IState>(states.Length);
        stateTable1 = new Dictionary<String, IState>(states.Length);

        foreach (CTMState state in states)
        {
            state.Initialize(animator, monster, this);
            stateTable1.Add(state.GetType().ToString().Split('_')[1], state);
            // stateTable.Add(state.GetType(), state);
        }
    }
    void Start()
    {
        SwitchOn(stateTable1["Idle"]);

    }
}
