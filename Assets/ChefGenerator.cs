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
    void Start()
    {

    }
    public void chefMovement()
    {
        chefObj.transform.DOMove(standpoint.ChefTemepPointPos.position, 1f).SetEase(Ease.Linear);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
