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


    /// <summary>
    /// 当接收分数时
    /// </summary>
    /// <returns></returns>
    void OnReceiveScore();

    /// <summary>
    /// 向服务器发出更新分数
    /// </summary>
    /// <param name="num"></param>
    void UpdataScore(string url, int num);
}
