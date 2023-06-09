using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSuggestion : MonoBehaviour
{
   
    public static FoodSuggestion instance;
    public FoodData foodDataSo;

   public static string foodItemsName;
    void Start()
    {
        //foodSuggest = new ();
        instance = this;


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void foodSuggetionCall(Image img)
    {
        int index;
     
        for (int i = 0; i < foodDataSo.foodDatas.Count; i++)
        {
            index = UnityEngine.Random.Range(0, foodDataSo.foodDatas.Count);
            img.sprite = foodDataSo.foodDatas[index].sprite;
            foodItemsName = foodDataSo.foodDatas[index].food.ToString();
            break;
        }
    }
}
