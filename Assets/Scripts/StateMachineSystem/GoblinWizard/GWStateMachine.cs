using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GWStateMachine : StateMachine
{
    [SerializeField] GameObject stateObject;
    public string monsterName;
    Animator animator;
    GWController monster;
    Type type;
    GWState[] states;
    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        monster = GetComponent<GWController>();

        // foreach (StateType state in Enum.GetValues(typeof(StateType)))
        // {
        //     type = Type.GetType(monsterName + "State_" + state.ToString());
        //     stateInstance = (IState)Activator.CreateInstance(type);
        //     //通过反射调用Initialize方法
        //     type.GetMethod("Initialize").Invoke(stateInstance, new object[] { animator, this });
        //     stateTable.Add(stateInstance.GetType(), stateInstance);
        // }
        states = stateObject.GetComponents<GWState>();
        // stateTable = new Dictionary<System.Type, IState>(states.Length);
        stateTable1 = new Dictionary<String, IState>(states.Length);

        foreach (GWState state in states)
        {
            state.Initialize(animator, monster, this);
            // stateTable.Add(state.GetType(), state);
            stateTable1.Add(state.GetType().ToString().Split("_")[1], state);
        }


    }
    void Start()
    {
        SwitchOn(stateTable1["Idle"]);
    }
}
