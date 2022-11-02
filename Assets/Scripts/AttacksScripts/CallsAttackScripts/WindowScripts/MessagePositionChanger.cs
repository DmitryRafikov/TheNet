using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
public class MessagePositionChanger : MonoBehaviour
{
    [SerializeField] private QueueContainer _queue;
    [SerializeField] private MessageSpawner _spawner;
    void Start()
    {
        _spawner.OnSpawn.AddListener(ChangeMessagesPosition);
    }
    private void ChangeMessagesPosition() 
    {
        var lastMessage = _queue.GetLastMessage();
        var rectTrans = lastMessage.GetComponent<RectTransform>();
        float height = rectTrans.sizeDelta.y;
        foreach (var item in _queue.Messages)
        {
            RectTransform _messageRect = item.GetComponent<RectTransform>();
            _messageRect.transform.localPosition += new Vector3(0, height, 0);
            //_messageRect.anchorMax += new Vector2(0, height);
            //_messageRect.anchorMin += new Vector2(0, height);
        }
    }
}
