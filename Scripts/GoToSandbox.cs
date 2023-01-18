using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSandbox : GAction
{
    public override bool PrePerform()
    {
        // Check if the sandbox is busy
        target = GWorld.Instance.RemoveSandbox();
        if (target == null)
        {
            return false;
        }
        
        GWorld.Instance.GetWorld().ModifyState("freesandbox", -1);
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.AddSandbox(target);
        GWorld.Instance.GetWorld().ModifyState("freesandbox", 1);
        return true;
    }
}
