﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateMachine
{
    public CharacterState currentState;

    public void Initialize(CharacterState startingState)
    {
        currentState = startingState;
        currentState.Enter();
    }

    public void ChangeState(CharacterState newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Enter();
    }
}
