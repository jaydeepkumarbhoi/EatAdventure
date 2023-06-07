using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CircleFillHandler : MonoBehaviour
{
    public float fillValue=0;
    public Image circleFillImage;
    public RectTransform fillHandler;
    public GameObject holder;
    public float speed =30f;
    public static bool isChefefoodPos;
    void Start()
    {
        holder.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CustomerGenerator.instance.isorderProgress == true)
        {
            holder.SetActive(true);

            if (fillValue <= 100)
                fillValue += Time.deltaTime * speed;
            else
            {
                gameObject.SetActive(false);
                isChefefoodPos = true;
            }

            fillcircleValue(fillValue);
        }
       
    }

    public void fillcircleValue(float value)
    {
        float fillAmount = (value / 100.0f);
        circleFillImage.fillAmount = fillAmount;
        float angle = fillAmount * 360;
        fillHandler.localEulerAngles = new Vector3(0, 0, -angle);

    }
}
