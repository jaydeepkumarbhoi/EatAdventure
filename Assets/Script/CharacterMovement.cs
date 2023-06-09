using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public static class CharacterMovement
{



    public static void MovementCall(Transform currentObjPos, Vector3 finalPos, Action callBack)
    {
        var sequence = DOTween.Sequence();

        sequence.Append(currentObjPos.transform.DOMove(finalPos, 1f).SetEase(Ease.Linear));
        sequence.OnComplete(() =>
        {
            callBack?.Invoke();
        });
    }



}
