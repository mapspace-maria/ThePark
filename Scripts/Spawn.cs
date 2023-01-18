using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject kid;
    public GameObject parent;
    public int numKid;
    public int numParent;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numKid; i++)
        {
            Instantiate(kid, this.transform.position, Quaternion.identity);
        }

        Invoke("SpawnKid", 5);

        for (int i = 0; i < numParent; i++)
        {
            Instantiate(parent, this.transform.position, Quaternion.identity);
        }

        Invoke("SpawnParent", 5);
    }

    void SpawnKid()
    {
        Instantiate(kid, this.transform.position, Quaternion.identity);
        Invoke("SpawnKid", Random.Range(2, 10));
    }

    void SpawnParent()
    {
        Instantiate(parent, this.transform.position, Quaternion.identity);
        Invoke("SpawnParent", Random.Range(2, 10));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
