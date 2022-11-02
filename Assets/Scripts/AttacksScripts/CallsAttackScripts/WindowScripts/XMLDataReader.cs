using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMLDataReader : MonoBehaviour
{
    [SerializeField] private QueueContainer _queue;
    [SerializeField] private GameObject MessageIn;
    [SerializeField] private GameObject MessageOut;
    void Start()
    {
    }
    public void CommitElementIn()
    {
        _queue.AddQueueElement(MessageIn);
    }
    public void CommitElementOut()
    {
        _queue.AddQueueElement(MessageOut);
    }

    private void DefineElementType() { }

    public void FindElement()
    {
        try
        {

        }
        catch (NullReferenceException) 
        {
            Debug.Log("элемент не найден");
        }
    }
}
