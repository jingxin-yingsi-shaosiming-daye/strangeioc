using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScoreService
{
    
    
    /// <summary>
    /// 向一个网址发出请求分数申请
    /// </summary>
    /// <param name="url"></param>
    void RequestScore(string url);


    int OnReceiveScore();
}
