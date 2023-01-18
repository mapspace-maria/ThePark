using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSittingArea : GAction
{
    public override bool PrePerform()
    {
        // Check if the swing is busy
        target = GWorld.Instance.RemoveSittingarea();
        if (target == null)
        {
            return false;
        }
        
        GWorld.Instance.GetWorld().ModifyState("freesittingarea", -1);
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.AddSittingarea(target);
        GWorld.Instance.GetWorld().ModifyState("freesittingarea", 1);
        return true;
    }
}
