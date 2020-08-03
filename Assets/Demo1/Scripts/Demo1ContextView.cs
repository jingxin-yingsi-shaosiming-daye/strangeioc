using System;
using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.impl;
using UnityEngine;

/// <summary>
/// root  启动入口
/// </summary>
public class Demo1ContextView : ContextView
{
    private void Awake()
    {
        this.context =new Demo1Context(this);
        //context.Start();
    }
}
