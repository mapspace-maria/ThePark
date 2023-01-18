using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kid : GAgent
{
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("arrivePark", 1, true);
        goals.Add(s1, 10);

        SubGoal s2 = new SubGoal("playWheel", 1, true);
        goals.Add(s2, 5);

        SubGoal s3 = new SubGoal("playSlider", 1, true);
        goals.Add(s3, 5);

        SubGoal s4 = new SubGoal("playSwing", 1, true);
        goals.Add(s4, 5);

        SubGoal s5 = new SubGoal("playSandbox", 1, true);
        goals.Add(s5, 3);

    }

}
