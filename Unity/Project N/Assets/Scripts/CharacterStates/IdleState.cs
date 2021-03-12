using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : CharacterState
{
    public IdleState(Character character, CharacterStateMachine characterStateMachine, CharacterData characterData, PlayerInputs playerInputs, string animBoolName) : base(character, characterStateMachine, characterData, playerInputs, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
        if (playerInputs.Right || playerInputs.Left)
        {
            characterStateMachine.ChangeState(character.moveState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
