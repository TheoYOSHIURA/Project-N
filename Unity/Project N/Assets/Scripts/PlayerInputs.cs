using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    public readonly KeyCode rightKey = KeyCode.D;
    public readonly KeyCode leftKey = KeyCode.A;

    private bool right;
    private bool left;

    public bool Right { get => right; set => right = value; }
    public bool Left { get => left; set => left = value; }

    void Update()
    {
        Right = Input.GetKey(rightKey);
        Left = Input.GetKey(leftKey);
    }
}
