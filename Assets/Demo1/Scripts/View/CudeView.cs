using System;
using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class CudeView : View
{


    public Text numText;
    /// <summary>
    /// 初始化
    /// 由media调用
    /// </summary>
    public void Init()
    {
        numText = transform.GetComponentInChildren<Text>();
    }

    private void Update()
    {
        //让立方体随机跑
        
        transform.Translate(new Vector3(Random.Range(-1,2),Random.Range(-1,2),Random.Range(-1,2)*.2f));
    }

    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
    }


    public void UpdataScore(int num)
    {
        numText.text = num.ToString();
    }
}
