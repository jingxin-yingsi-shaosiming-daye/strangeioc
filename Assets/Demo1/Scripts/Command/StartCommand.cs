using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;


/// <summary>
/// 开始命令
/// </summary>
public class StartCommand : Command
{
    public override void Execute()
    {
        Debug.Log("StartCommand : Exec");
    }
}
