using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;

/// <summary>
/// 上传分数控制器
/// </summary>
public class UpScoreCommand : EventCommand
{

    #region 000 注入的对象
    
    [Inject]
    public ScoreModel scoreModel { get; set; }
    

    
    [Inject]
    public IScoreService service { get; set; }
    
    #endregion
    
    
    
    public override void Execute()
    {
        

        scoreModel.score++;
        
        service.UpdataScore("http://xx.xx",scoreModel.score);
        

        dispatcher.Dispatch(DemoMediatorEvent.RefashScore,scoreModel.score);
    }
}