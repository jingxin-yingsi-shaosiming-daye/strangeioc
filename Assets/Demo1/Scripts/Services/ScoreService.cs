using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreService : IScoreService
{
   
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
    }

    public void UpdataScore(string url, int num)
    {
       Debug.Log("更新分数" +url +"分数:"+num);
    }
}
