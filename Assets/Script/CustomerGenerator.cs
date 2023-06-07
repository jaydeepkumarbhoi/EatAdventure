using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerGenerator : MonoBehaviour
{

    public int[] counter;
    public List<GameObject> customerPoints;
    public List<GameObject> shafePoint;
    public List<GameObject> shafePoint2;
    GameObject customer;
    public GameObject shafeChar;

    public bool isSafemove=false;

    Action OnShafeAlert;

    public bool isorderProgress = false;

    public static CustomerGenerator instance;

    private void OnEnable()
    {
        //OnShafeAlert += ShafeMovement;
    }
    private void Start()
    {
        instance = this;
        customer = CustomerObjPool.instance.getPoolGameObject();

        if (customer != null)
        {
            customer.transform.position = transform.position;
            customer.transform.rotation = transform.rotation;
            customer.SetActive(true);


            StartCoroutine(customerMovement(customer, customerPoints[0]));
        }

    }


    IEnumerator foodPos(GameObject shapePoint, GameObject shafeChar)
    {
        if (CircleFillHandler.isChefefoodPos == true)
        {
            while (true)
            {

                shafeChar.transform.position = Vector3.MoveTowards(shafeChar.transform.position,
               new Vector3(shapePoint.transform.position.x, shafeChar.transform.position.y, shapePoint.transform.position.z), 2f * Time.deltaTime);



                if (shafeChar.transform.position.x == shapePoint.transform.position.x)
                {
                    isorderProgress = true;

                    Debug.Log("Hey---" + isorderProgress);
                    break;
                }

                yield return null;
                yield return StartCoroutine(shafeMovement(shafeChar, shafePoint[0]));
            }
        }


    }



    IEnumerator shafeMovement(GameObject shafeChar, GameObject shapePoint)
    {
      

            while (true)
            {

                shafeChar.transform.position = Vector3.MoveTowards(shafeChar.transform.position,
               new Vector3(shapePoint.transform.position.x, shafeChar.transform.position.y, shapePoint.transform.position.z), 2f * Time.deltaTime);



                if (shafeChar.transform.position.x == shapePoint.transform.position.x)
                {
                    isorderProgress = true;

                    Debug.Log("Hey---" + isorderProgress);
                    break;
                }

                yield return null;
                yield return StartCoroutine(foodPos(shafeChar, shafePoint[0]));
            }

        
        
        


    }


    IEnumerator customerMovement(GameObject playerPos, GameObject targetPos)
    {


        yield return new WaitForSeconds(3f);
        {
            while (true)
            {
                playerPos.transform.position = Vector3.MoveTowards(playerPos.transform.position,
           new Vector3(targetPos.transform.position.x, playerPos.transform.position.y, playerPos.transform.position.z), 2f * Time.deltaTime);


                if (playerPos.transform.position.x == targetPos.transform.position.x)
                {
                    break;
                }
                yield return null;
            }
            yield return new WaitForSeconds(0.5f);
            yield return StartCoroutine(shafeMovement(shafeChar, shafePoint[0]));
        }
    }


   
   

}
