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

    
    
    [Inject(ContextKeys.CONTEXT_DISPATCHER)]            //向构造工厂申请一个全局事件调配员     //应用上下文工厂里的事件调配器
    public IEventDispatcher dispatcher { get; set; }
    
    /// <summary>
    /// 当所有的属性注入完毕时 触发
    /// </summary>
    public override void OnRegister()
    {
        
        
        base.OnRegister();
        CubeView.Init();
        Debug.Log(CubeView);
        
        
        dispatcher.AddListener(DemoMediatorEvent.RefashScore,OnScoreChange);
        
        dispatcher.Dispatch(Demo1CommandEvent.RequestScoreCommand);//在mediator发布  局部事件  全局命令必须用全局事件分发器
        
    }

    public override void OnRemove()
    {
        dispatcher.RemoveListener(DemoMediatorEvent.RefashScore,OnScoreChange);

    }

    private void OnScoreChange(IEvent evt)
    {
        CubeView.UpdataScore((int)evt.data);
    }
}
