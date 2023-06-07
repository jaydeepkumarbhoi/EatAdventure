using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public  class CharacterMovement : MonoBehaviour
{

    public  void MovementCall(Transform currentObjPos, Vector3 finalPos, Action callBack)
    {
        StartCoroutine(ObjMovement( currentObjPos,  finalPos,  callBack));
    }


    IEnumerator ObjMovement(Transform currentObjPos, Vector3 finalPos, Action callBack)
    {

        currentObjPos.position = Vector3.MoveTowards(currentObjPos.position,
             finalPos, 2f * Time.deltaTime);

        callBack?.Invoke();


        yield return null;
    }

 
}
