using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerObjPool : MonoBehaviour
{
    public static CustomerObjPool instance;
    public List<GameObject> customerListPool;
    public GameObject cust_Obj_PoolPrefab;
    public int poolAmount;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        customerListPool = new List<GameObject>();
        GameObject temp_Cust_obj;

        for (int i = 0; i < poolAmount; i++)
        {
            temp_Cust_obj = Instantiate(cust_Obj_PoolPrefab);
            temp_Cust_obj.SetActive(false);
            customerListPool.Add(temp_Cust_obj);
        }

    }

    public GameObject getPoolGameObject()
    {

        for (int i = 0; i < poolAmount; i++)
        {
            if (!customerListPool[i].activeInHierarchy)
            {
                return customerListPool[i];
            }
        }

        return null;

    }



}


