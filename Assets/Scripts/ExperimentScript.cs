using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperimentScript : MonoBehaviour
{
    public GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CallDebudByClick() {
        Debug.Log("Click");
    }
    void ChangePosition() {

        Vector3 changePos = image.transform.position;
        //changePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        changePos.x = Input.mousePosition.x;
        changePos.y = Input.mousePosition.y;
        image.transform.position = changePos;
    }
    public void Activate()
    {
        if (image.activeSelf)
        {
            image.SetActive(false);
        }
        else
        {
            image.SetActive(true);
            ChangePosition();
        }
    }
}
