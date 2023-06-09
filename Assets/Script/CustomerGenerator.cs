using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CustomerGenerator : MonoBehaviour
{

   
    public List<GameObject> customerPoints;

    GameObject customer;
   
    public static CustomerGenerator instance;
   
  public CustomerMove customerMove;

    StandPoint sp;
    private void Start()
    {


        instance = this;

        for (int i = 1; i <= 3; i++)
        {
            customer = CustomerObjPool.instance.getPoolGameObject();

        }



        if (customer != null)
        {
            customer.transform.position = transform.position;
            customer.transform.rotation = transform.rotation;
            customer.SetActive(true);

             if (StandPoint.instance.CustomerTempPointPos != null)
                   customerMove.GotoCustomerCounter();
        }

    }


}
