using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodSuggestion : MonoBehaviour
{
    public List<Sprite> foodSuggest;
    public static FoodSuggestion instance;

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

        for (int i = 0; i <= foodSuggest.Count; i++)
        {
            img.sprite = foodSuggest[Random.Range(0, foodSuggest.Count)];

            // Debug.Log("Random" + Random.Range(0, foodSuggest.Count - 1));
        }
    }
}
