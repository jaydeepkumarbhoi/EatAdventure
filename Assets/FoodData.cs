using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Food", menuName = "FoodData")]
public class FoodData : ScriptableObject
{
    public List<FoodItems> foodDatas;
}

[Serializable]
public class FoodItems
{
    public Food food;
    public Sprite sprite;
}

public enum Food
{
    Burger,
    Tea,
    Drink,
    FrenchFries,
    HotDog
}
