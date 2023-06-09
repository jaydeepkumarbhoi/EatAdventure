using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class StandPoint : MonoBehaviour
{
    public List<counter> CustomerCounter;

    public Transform CustomerTempPointPos;
    public Transform ChefTemepPointPos;

    public static StandPoint instance;
    private void Awake()
    {
        instance = this;
        getOccupyCounter();
        
    }

 

    public void getOccupyCounter()
    {
        for (int i = 0; i <= CustomerCounter.Count; i++)
        {
            if (CustomerCounter[i].isOccupy == false)
            {
                GetCustomerPointPos(CustomerCounter[i].CustomerPointPos);
                GetChefPointPos(CustomerCounter[i].ChefPointPos);
                CustomerCounter[i].isOccupy = true;
                break;
            }

        }
    }


    private void GetCustomerPointPos(Transform transform)
    {
        CustomerTempPointPos = transform;
    }

    private void GetChefPointPos(Transform transform)
    {
        ChefTemepPointPos = transform;
    }
}


[Serializable]
public class counter
{

    public Transform CustomerPointPos;
    public Transform ChefPointPos;

    public bool isOccupy;
}    
