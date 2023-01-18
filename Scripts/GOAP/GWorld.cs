using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GWorld
{
    private static readonly GWorld instance = new GWorld();
    private static WorldStates world;
    private static Queue<GameObject> wheels;
    private static Queue<GameObject> sittingarea;
    private static Queue<GameObject> sliders;
    private static Queue<GameObject> swings;
    private static Queue<GameObject> eatingarea;
    private static Queue<GameObject> sandbox;
    private static Queue<GameObject> kid;
    // private static Queue<GameObject> restaurant;
    


    static GWorld()
    {
        world = new WorldStates();
        wheels = new Queue<GameObject>();
        sittingarea = new Queue<GameObject>();
        sliders = new Queue<GameObject>();
        swings = new Queue<GameObject>();
        eatingarea = new Queue<GameObject>();
        sandbox = new Queue<GameObject>();
        kid = new Queue<GameObject>();
        // restaurant = new Queue<GameObject>();

        GameObject[] wheelsList = GameObject.FindGameObjectsWithTag("wheels");
        foreach (GameObject wh in wheelsList)
            wheels.Enqueue(wh);
        if (wheelsList.Length > 0)
            world.ModifyState("freewheel", wheelsList.Length);

        GameObject[] sittingareaList = GameObject.FindGameObjectsWithTag("sittingarea");
        foreach (GameObject sa in sittingareaList)
            sittingarea.Enqueue(sa);
        if (sittingareaList.Length > 0)
            world.ModifyState("freesittingarea", sittingareaList.Length);

        GameObject[] slidersList = GameObject.FindGameObjectsWithTag("sliders");
        foreach (GameObject sl in slidersList)
            sliders.Enqueue(sl);
        if (slidersList.Length > 0)
            world.ModifyState("freesliders", slidersList.Length);

        GameObject[] swingsList = GameObject.FindGameObjectsWithTag("swings");
        foreach (GameObject sw in swingsList)
            swings.Enqueue(sw);
        if (swingsList.Length > 0)
            world.ModifyState("freeswing", swingsList.Length);

        GameObject[] eatingareaList = GameObject.FindGameObjectsWithTag("eatingarea");
        foreach (GameObject ea in eatingareaList)
            eatingarea.Enqueue(ea);
        if (eatingareaList.Length > 0)
            world.ModifyState("freeeatingarea", eatingareaList.Length);

        // GameObject[] restaurantList = GameObject.FindGameObjectsWithTag("buymeal");
        // foreach (GameObject rt in restaurantList)
        //     restaurant.Enqueue(rt);
        // if (restaurantList.Length > 0)
        //     world.ModifyState("freebuymeal", restaurantList.Length);

        GameObject[] sandboxList = GameObject.FindGameObjectsWithTag("sandbox");
        foreach (GameObject sb in sandboxList)
            sandbox.Enqueue(sb);
        if (sandboxList.Length > 0)
            world.ModifyState("freesandbox", sandboxList.Length);

        GameObject[] kidList = GameObject.FindGameObjectsWithTag("kid");
        foreach (GameObject kd in kidList)
            kid.Enqueue(kd);
        if (kidList.Length > 0)
            world.ModifyState("freekid", kidList.Length);

        Time.timeScale = 5;

    }

    private GWorld()
    {
    }

    public void AddWheels(GameObject wh)
    {
        wheels.Enqueue(wh);
    }
    public GameObject RemoveWheels()
    { 
        if (wheels.Count == 0) return null;
        return wheels.Dequeue();
    }

    public void AddSittingarea(GameObject sa)
    {
        sittingarea.Enqueue(sa);
    }
    public GameObject RemoveSittingarea()
    {
        if (sittingarea.Count == 0) return null;
        return sittingarea.Dequeue();
    }

    public void AddSliders(GameObject sl)
    {
        sliders.Enqueue(sl);
    }
    public GameObject RemoveSliders()
    {
        if (sliders.Count == 0) return null;
        return sliders.Dequeue();
    }

    public void AddSwings(GameObject sw)
    {
        swings.Enqueue(sw);
    }
    public GameObject RemoveSwings()
    {
        if (swings.Count == 0) return null;
        return swings.Dequeue();
    }


    public void AddEatingarea(GameObject ea)
    {
        eatingarea.Enqueue(ea);
    }
    public GameObject RemoveEatingarea()
    {
        if (eatingarea.Count == 0) return null;
        return eatingarea.Dequeue();
    }

    // public void AddRestaurant(GameObject rt)
    // {
    //     restaurant.Enqueue(rt);
    // }
    // public GameObject RemoveRestaurant()
    // {
    //     if (restaurant.Count == 0) return null;
    //     return restaurant.Dequeue();
    // }


    public void AddSandbox(GameObject sb)
    {
        sandbox.Enqueue(sb);
    }
    public GameObject RemoveSandbox()
    {
        if (sandbox.Count == 0) return null;
        return sandbox.Dequeue();
    }

    public void AddKid(GameObject kd)
    {
        kid.Enqueue(kd);
    }
    public GameObject RemoveKid()
    {
        if (kid.Count == 0) return null;
        return kid.Dequeue();
    }




    public static GWorld Instance
    {
        get { return instance; }
    }

    public WorldStates GetWorld()
    {
        return world;
    }
}

