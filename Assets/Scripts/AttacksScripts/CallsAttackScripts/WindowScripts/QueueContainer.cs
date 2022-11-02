using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QueueContainer : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent OnCountChange;
    private List<GameObject> MessagesQueue;
    public IReadOnlyCollection<GameObject> Messages;
    private void Awake()
    {
        MessagesQueue = new List<GameObject>();
        Messages = MessagesQueue;
    }
    public GameObject GetLastMessage()
    {
        return MessagesQueue[MessagesQueue.Count-1];
    }
    public void AddQueueElement(GameObject message)
    {
        MessagesQueue.Add(message);
        OnCountChange.Invoke();
    }
}
