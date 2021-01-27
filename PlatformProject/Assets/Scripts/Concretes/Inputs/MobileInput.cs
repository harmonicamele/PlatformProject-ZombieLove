using Assets.GameFolders.Scripts.Abstracts.Inputs;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileInput : IPlayerInput
{
    public float Horizontal => Input.GetAxis("Horizontal");
    public bool isJumpButton => Input.GetButtonDown("Jump");

    public bool isrun => Input.GetKey(KeyCode.LeftShift);
}
    



