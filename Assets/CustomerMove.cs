using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMove : MonoBehaviour
{
    
    void Start()
    {

     
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void GotoCustomerCounter()
    {
        CharacterMovement.MovementCall(gameObject.transform, StandPoint.instance.CustomerTempPointPos.position, ChefGenerator.instance.OnmoveChef);
    }
}
