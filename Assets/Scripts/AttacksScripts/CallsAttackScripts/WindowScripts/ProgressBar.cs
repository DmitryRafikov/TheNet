using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    [SerializeField] private float FillSpeed = 0.1f;
    [SerializeField] private float targetProgress = 0;
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    void Update()
    {
        DecreaseProgressValue();
    }

    private void DecreaseProgressValue()
    {
        if (slider.value > targetProgress)
            slider.value -= FillSpeed * Time.deltaTime;
    }

    public void ResetProperties()
    {
        slider.value = 1;
    }

}
