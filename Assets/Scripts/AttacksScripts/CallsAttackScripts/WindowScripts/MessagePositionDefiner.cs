using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePositionDefiner : MonoBehaviour
{
    public enum MessageType {Incoming, Outgoing};
    public MessageType DropDown = MessageType.Outgoing;
    RectTransform MessageRect;
    private void Awake()
    {
        MessageRect = gameObject.GetComponent<RectTransform>();
    }
    private void Start()
    {
        SetMessageAnchorPosition(MessageRect);
    }
    private Vector3 GetVectorPositionByMessageType()
    {
        if (DropDown == MessageType.Outgoing)
            return new Vector3(1, 0, 0);            
        return new Vector3(0,0,0);
    }
    private void SetMessageAnchorPosition(RectTransform messageRect)
    {
        messageRect.anchorMax = GetVectorPositionByMessageType();
        messageRect.anchorMin = GetVectorPositionByMessageType();
    }
}
