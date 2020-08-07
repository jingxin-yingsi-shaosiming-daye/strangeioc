using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

/// <summary>
/// 请求分数
/// </summary>
public class RequestScoreCommand : EventCommand//有全局事件调度员的命令对象
{

    [Inject] public IScoreService service { get; set; }

    
    [Inject]
    public ScoreModel scoreModel { get; set; }


    public override void Execute()
    {
        
        Retain();//在收到回调函数之前不要销毁这个命令对象
        service.dispatcher.AddListener(Demo1ServiceEvent.ReceiveScore, OnServiceReceiveScore);
        
        
        Debug.Log("控制层 调用服务层联网获取分数");
        service.RequestScore("http://xx.xx.xx");
        
      

       
    }

    private void OnServiceReceiveScore(IEvent evt)
    {
        Debug.Log("控制层: 接收到服务层分发的数据 分数数据");
        Debug.Log("收到服务器的分数");
        
        //1 保存到model层
        scoreModel.score = (int) evt.data;
        
        //2 控制层接收到数据 分发事件
        dispatcher.Dispatch(DemoMediatorEvent.RefashScore,evt);
        
        //3 移除事件
        service.dispatcher.RemoveListener(Demo1ServiceEvent.ReceiveScore, OnServiceReceiveScore);
        Release();//释放这个命令
    }

}
