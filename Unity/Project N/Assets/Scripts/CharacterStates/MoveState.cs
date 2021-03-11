using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : CharacterState
{
    private Transform transform;
    private float xPos = 0;

    public MoveState(Character character, CharacterStateMachine characterStateMachine, CharacterData characterData, PlayerInputs playerInputs, string animBoolName) : base(character, characterStateMachine, characterData, playerInputs, animBoolName)
    {
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();

        transform = character.GetComponent<Transform>();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();

        int direction = Convert.ToInt32(playerInputs.Right) - Convert.ToInt32(playerInputs.Left);
        float acceleration = (characterData.moveSpeed/1000) * direction;
        xPos = (xPos + acceleration) * characterData.friction;


        transform.position = new Vector3(transform.position.x + xPos, transform.position.y, transform.position.z);
    }
}
