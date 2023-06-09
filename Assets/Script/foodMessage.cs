using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class foodMessage : MonoBehaviour
{
    public Image foodImg;
    public GameObject foodPopup;
    void Start()
    {


        FoodSuggestion.instance.foodSuggetionCall(foodImg);

        StartCoroutine(callSuggetion());

    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator callSuggetion()
    {

        while (true)
        {


           // if (CustomerGenerator.instance.isorderProgress == true)
            {

                foodPopup.SetActive(true);
                break;
            }
            yield return null;
        }

    }
}
