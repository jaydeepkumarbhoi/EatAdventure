using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CustomerGenerator : MonoBehaviour
{

    public int[] counter;
    public List<GameObject> customerPoints;

    GameObject customer;
    public bool isorderProgress;
    public static CustomerGenerator instance;
    StandPoint sp;
    public StandPoint standpoint;
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

            if (standpoint.CustomerTempPointPos.position != null)
                CharacterMovement.MovementCall(customer.transform, standpoint.CustomerTempPointPos.position, ChefGenerator.instance.OnmoveChef);

        }

    }


}
