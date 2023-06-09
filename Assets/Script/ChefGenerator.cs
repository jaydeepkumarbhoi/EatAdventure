using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class ChefGenerator : MonoBehaviour
{
    public Action OnmoveChef;

    public List<GameObject> chefPoint;

    public GameObject chefObj;

    public static ChefGenerator instance;
    public StandPoint standpoint;
    private void OnEnable()
    {
        instance = this;
        OnmoveChef += chefMovement;
    }
    private void OnDisable()
    {
        OnmoveChef -= chefMovement;
    }
    void Start()
    {

    }
    public void chefMovement()
    {

        var sequence = DOTween.Sequence();
        sequence.Append(chefObj.transform.DOMove(standpoint.ChefTemepPointPos.position, 1f).SetEase(Ease.Linear));
        sequence.OnComplete(() => {
           // CustomerGenerator.instance.isorderProgress = true;
        });
    }

   

    // Update is called once per frame
    void Update()
    {

    }
}
