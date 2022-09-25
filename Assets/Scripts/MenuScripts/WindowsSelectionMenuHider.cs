using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class WindowsSelectionMenuHider : MonoBehaviour//, IPointerDownHandler
{
    public GameObject MenuPanel;
    public GameObject WorkArea;
    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SendPiska() => Debug.Log("клавиша нажата");
    public bool CheckMenuOpened() => MenuPanel.gameObject.activeSelf == true ? true : false;

    public void SwitchMenu() {
        Debug.Log("клавиша нажата");
        //active = CheckMenuOpened();
        if (MenuPanel.gameObject.activeSelf)
            MenuPanel.gameObject.SetActive(false);
        else {
            MenuPanel.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
            MenuPanel.gameObject.SetActive(true);
        }
    }
}
