using System;
using System.Collections;
using System.Collections.Generic;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CubeView : View
{


    #region 000 事件调度管理员

    [Inject]
    public IEventDispatcher dispatcher { get; set; }

    #endregion
    

    public Text numText;

    #region 010 初始化

    /// <summary>
    /// 初始化
    /// 由media调用
    /// </summary>
    public void Init()
    {
        numText = transform.GetComponentInChildren<Text>();
    }

    #endregion

    #region 011 生命周期函数

    private void Update()
    {
        //让立方体随机跑
        
        transform.Translate(new Vector3(Random.Range(-1,2),Random.Range(-1,2),Random.Range(-1,2))*.02f);
    }

    #endregion

    
    #region 013 unity内置事件

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        dispatcher.Dispatch(DemoMediatorEvent.ClickCube);
    }

    #endregion
   

    


    public void UpdataScore(int num)
    {
        numText.text = num.ToString();
    }
}
