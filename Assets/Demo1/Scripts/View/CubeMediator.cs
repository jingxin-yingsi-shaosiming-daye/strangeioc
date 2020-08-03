using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;




public class CubeMediator : Mediator
{

    [Inject]
    public CubeView CubeView { get; set; }

    
    
    [Inject(ContextKeys.CONTEXT_DISPATCHER)]            //全局事件分发器
    public IEventDispatcher Dispatcher { get; set; }
    
    /// <summary>
    /// 当所有的属性注入完毕时 触发
    /// </summary>
    public override void OnRegister()
    {
        base.OnRegister();
        CubeView.Init();
        Debug.Log(CubeView);
        
        Dispatcher.Dispatch(Demo1CommandEvent.RequestScoreCommand);//在mediator发布  局部事件  全局命令必须用全局事件分发器
        
    }

    public override void OnRemove()
    {
        base.OnRemove();
    }
}
