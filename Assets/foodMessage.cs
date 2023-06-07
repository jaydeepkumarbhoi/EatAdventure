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
        Debug.Log("jjj");
        while (true)
        {
            Debug.Log("jjaaajj");

            if (CustomerGenerator.instance.isorderProgress == true)
            {
                Debug.Log("jjsssssj");

                foodPopup.SetActive(true);
                break;
            }
            yield return null;
        }

    }
}
