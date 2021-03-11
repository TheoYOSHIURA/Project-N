using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public CharacterStateMachine characterStateMachine;
    private CharacterData characterData;

    public CharacterState idleState;
    public CharacterState moveState;

    public PlayerInputs playerInputs;

    private void Awake()
    {
        characterStateMachine = new CharacterStateMachine();
        characterData = new CharacterData();
        playerInputs = GetComponent<PlayerInputs>();

        idleState = new IdleState(this, characterStateMachine, characterData, playerInputs, "");
        moveState = new MoveState(this, characterStateMachine, characterData, playerInputs, "");
    }

    private void Start()
    {
        characterStateMachine.Initialize(idleState);
    }

    private void Update()
    {
        characterStateMachine.currentState.LogicUpdate();
    }

    private void FixedUpdate()
    {
        characterStateMachine.currentState.PhysicsUpdate();
    }
}
