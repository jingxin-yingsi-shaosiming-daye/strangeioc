using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;


public class CubeMediator : Mediator
{
    #region 000 全局事件调度者

    [Inject(ContextKeys.CONTEXT_DISPATCHER)] //向构造工厂申请一个全局事件调配员     //应用上下文工厂里的事件调配器
    public IEventDispatcher dispatcher { get; set; }

    #endregion


    #region 001 注入视图

    [Inject] public CubeView cubeView { get; set; }

    #endregion


    #region 002 mediator生命周期函数

    /// <summary>
    /// 当所有的属性注入完毕时 触发
    /// </summary>
    public override void OnRegister()
    {
        base.OnRegister();
        cubeView.Init();
        Debug.Log(cubeView);


        dispatcher.AddListener(DemoMediatorEvent.RefashScore, OnScoreChange);
        cubeView.dispatcher.AddListener(DemoMediatorEvent.ClickCube,OnCubeClick);
        

        dispatcher.Dispatch(Demo1CommandEvent.RequestScoreCommand); //在mediator发布  局部事件  全局命令必须用全局事件分发器
    }

    public override void OnRemove()
    {
        dispatcher.RemoveListener(DemoMediatorEvent.RefashScore, OnScoreChange);
        cubeView.dispatcher.RemoveListener(DemoMediatorEvent.ClickCube,OnCubeClick);

    }

    #endregion


    #region 003 事件响应函数

    private void OnScoreChange(IEvent evt)
    {
        cubeView.UpdataScore((int) evt.data);
    }



    /// <summary>
    /// 当方块被点击时触发
    /// </summary>
    private void OnCubeClick()
    {
        dispatcher.Dispatch(Demo1CommandEvent.UpScoreCommand);
    }

#endregion
}

