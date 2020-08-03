using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;

public class RequestScoreCommand : Command
{

    [Inject]
    public IScoreService Service { get; set; }
    
    
    public override void Execute()
    {
        Service.RequestScore("http://xx.xx.xx");
    }
}
