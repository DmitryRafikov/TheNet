using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Message;
    [SerializeField] private RectTransform ContentContainer;
    void Start()
    {
        Spawn(Message, ContentContainer);
    }
    public void Spawn(GameObject message, RectTransform container) 
    {
        var newMessage = Instantiate(message);
        newMessage.transform.SetParent(container, false);
        newMessage.transform.localScale = Vector3.one;       
    }
}
