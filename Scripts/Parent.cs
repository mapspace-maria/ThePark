using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parent : GAgent
{

    public GameObject kid;

    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("arrivePark", 1, true);
        goals.Add(s1, 10);

        SubGoal s2 = new SubGoal("buyTicket", 1, true);
        goals.Add(s2, 5);

        SubGoal s3 = new SubGoal("sitDown", 1, true);
        goals.Add(s3, 5);

        SubGoal s4 = new SubGoal("eatMeal", 1, true);
        goals.Add(s4, 5);

    }

}
