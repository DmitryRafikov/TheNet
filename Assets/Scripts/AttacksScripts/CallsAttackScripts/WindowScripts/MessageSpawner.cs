using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MessageSpawner : MonoBehaviour
{
    [SerializeField] private GameObject MessageIn;
    [SerializeField] private GameObject MessageOut;
    [SerializeField] private RectTransform ContentContainer;
    [SerializeField] private QueueContainer MessagesQueue;
    public UnityEvent OnSpawn;
    void Start()
    {
        MessagesQueue.OnCountChange.AddListener(Spawn);
    }
    public void Spawn() 
    {
        var newMessage = Instantiate(MessagesQueue.GetLastMessage());
        newMessage.transform.SetParent(ContentContainer, false);
        newMessage.transform.localScale = Vector3.one;
        OnSpawn.Invoke();
    }
}