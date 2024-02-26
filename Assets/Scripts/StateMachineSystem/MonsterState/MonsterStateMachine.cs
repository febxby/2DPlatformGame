using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
enum StateType
{
    Idle,
    Patrol,
    Chase,
    Attack,
    Hurt,
    Dead,
    BeAttack
}
public class MonsterStateMachine : StateMachine
{
    [SerializeField] protected GameObject stateObject;
    public string monsterName;
    protected Animator animator;
    protected MonsterController monster;
    protected Type type;
    protected MonsterState[] states;
    virtual protected void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        monster = GetComponent<MonsterController>();

        // foreach (StateType state in Enum.GetValues(typeof(StateType)))
        // {
        //     type = Type.GetType(monsterName + "State_" + state.ToString());
        //     stateInstance = (IState)Activator.CreateInstance(type);
        //     //通过反射调用Initialize方法
        //     type.GetMethod("Initialize").Invoke(stateInstance, new object[] { animator, this });
        //     stateTable.Add(stateInstance.GetType(), stateInstance);
        // }
        states = stateObject.GetComponents<MonsterState>();
        // stateTable = new Dictionary<System.Type, IState>(states.Length);
        stateTable1 = new Dictionary<String, IState>(states.Length);

        foreach (MonsterState state in states)
        {
            state.Initialize(animator, monster, this);
            stateTable1.Add(state.GetType().ToString().Split('_')[1], state);
            // stateTable.Add(state.GetType(), state);
        }


    }
    virtual protected void Start()
    {
        // SwitchOn(stateTable[typeof(MonsterState_Idle)]);
        SwitchOn(stateTable1["Idle"]);

        
    }
}
