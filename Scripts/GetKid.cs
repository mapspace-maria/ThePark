using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKid : GAction
{
    public override bool PrePerform()
    {
        target = GWorld.Instance.RemoveKid();
        if (target == null)
            return false;


        GWorld.Instance.GetWorld().ModifyState("freeKid", -1);
        return true;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
