using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToSlider : GAction
{
    public override bool PrePerform()
    {
        // Check if the wheel is busy
        target = GWorld.Instance.RemoveSliders();
        if (target == null)
        {
            return false;
        }
        
        GWorld.Instance.GetWorld().ModifyState("freeslider", -1);
        return true;
    }

    public override bool PostPerform()
    {
        GWorld.Instance.AddWheels(target);
        GWorld.Instance.GetWorld().ModifyState("freewheel", 1);
        return true;
    }
}
