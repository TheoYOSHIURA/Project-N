using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterState
{
    protected Character character;
    protected CharacterStateMachine characterStateMachine;
    protected CharacterData characterData;
    protected PlayerInputs playerInputs;

    protected float startTime;

    private string animBoolName;

    public CharacterState(Character character, CharacterStateMachine characterStateMachine, CharacterData characterData, PlayerInputs playerInputs, string animBoolName)
    {
        this.character = character;
        this.characterStateMachine = characterStateMachine;
        this.characterData = characterData;
        this.playerInputs = playerInputs;
        this.animBoolName = animBoolName;
    }

    public virtual void Enter()
    {
        DoChecks();
        startTime = Time.time;
        Debug.Log("Entering: " + characterStateMachine.currentState);
    }

    public virtual void Exit()
    {

    }

    public virtual void LogicUpdate()
    {
        int direction = Convert.ToInt32(playerInputs.Right) - Convert.ToInt32(playerInputs.Left);
        
    }

    public virtual void PhysicsUpdate()
    {
        DoChecks();
    }

    public virtual void DoChecks()
    {

    }
}
