using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterData
{
    public readonly float moveSpeed;
    public readonly float friction;

    public readonly float airSpeed;
    public readonly float airFriction;

    public readonly float weight;
    public readonly float fallSpeed;
    public readonly float jumpDuration;
    public readonly float jumpHeight;

    public readonly float percentage;

    public CharacterData(float moveSpeed = 20, float friction = 0.9f, float airSpeed = 1, float airFriction = 1, float weight = 1, float fallSpeed = 1, float jumpDuration = 1, float jumpHeight = 1)
    {
        this.moveSpeed = moveSpeed;
        this.friction = friction;
        this.airSpeed = airSpeed;
        this.airFriction = airFriction;
        this.weight = weight;
        this.fallSpeed = fallSpeed;
        this.jumpDuration = jumpDuration;
        this.jumpHeight = jumpHeight;
    }
}
