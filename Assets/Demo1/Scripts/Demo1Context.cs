using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using strange.framework.api;
using UnityEngine;



/// <summary>
/// 上下文内容
/// </summary>
public class Demo1Context : MVCSContext
{


    public Demo1Context(MonoBehaviour view) : base(view)
    {
        
    }

    
    protected override void mapBindings()
    {
        base.mapBindings();

        #region 1 models bind

        

        #endregion

        #region 2 mediator bind

        mediationBinder.Bind<CubeView>().To<CubeMediator>();
        

        #endregion

        #region 3 command bind

        

        #endregion

        #region 4 service bind

        

        #endregion




        //因为这个命令绑定后就要执行 所以放到最后面
        #region 9 StartCommand

        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once(); //绑定开始内置事件


        #endregion


    }
}
