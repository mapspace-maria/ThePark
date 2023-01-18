using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSwing : GAction
{
    public override bool PrePerform()
    {
        // Check if the swing is busy
        target = GWorld.Instance.RemoveSwings();
        if (target == null)
        {
            return false;
        }
        
        GWorld.Instance.GetWorld().ModifyState("freeswing", -1);
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.AddSwings(target);
        GWorld.Instance.GetWorld().ModifyState("freeswing", 1);
        return true;
    }
}
