using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;




public class CubeMediator : Mediator
{

    [Inject]
    public CubeView CubeView { get; set; }

    /// <summary>
    /// 当所有的属性注入完毕时 触发
    /// </summary>
    public override void OnRegister()
    {
        base.OnRegister();
        Debug.Log(CubeView);
    }

    public override void OnRemove()
    {
        base.OnRemove();
    }
}
