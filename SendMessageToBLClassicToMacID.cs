using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public struct SendMessageToBLClassicToMacId : IZhuLiCommand
{
    public string m_deviceMacId;
    public string m_messageToSend;

   
    public SendMessageToBLClassicToMacId(string deviceMacId, string messageToSend)
    {
        m_deviceMacId = deviceMacId;
        m_messageToSend = messageToSend;
    }
}
[System.Serializable]
public class SendMessageToBLClassicToMacIdEvent: UnityEvent<SendMessageToBLClassicToMacId>
{}
