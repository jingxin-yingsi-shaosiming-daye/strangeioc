using System.Collections;
using System.Collections.Generic;
using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

public class ScoreService : IScoreService
{
    [Inject]
    public IEventDispatcher dispatcher { get; set; }

    /// <summary>
    /// 向一个网址发出请求分数申请
    /// </summary>
    /// <param name="url"></param>
    public void RequestScore(string url)
    {
        Debug.Log("请求服务器分数数据");
        OnReceiveScore();
        
        
        
       
    }
    
    
    
    
    
    
    
    

    public void OnReceiveScore()
    {
        int score = Random.Range(0, 100);
        
        
        Debug.Log("服务层: 分发 '接收分数' 事件");
        
        dispatcher.Dispatch(Demo1ServiceEvent.ReceiveScore,score);
    }
    
    
    
    
    
    
    
    
    

    public void UpdataScore(string url, int num)
    {
        Debug.Log("更新分数" + url + "分数:" + num);
    }
}