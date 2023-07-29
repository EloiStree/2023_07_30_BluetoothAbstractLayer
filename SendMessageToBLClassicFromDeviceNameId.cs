using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SendMessageToBLClassicFromDeviceNameId : IZhuLiCommand
{
    public string m_deviceNamedId;
    public string m_messageToSend;

    public SendMessageToBLClassicFromDeviceNameId(string deviceNamedId, string messageToSend)
    {
        m_deviceNamedId = deviceNamedId;
        m_messageToSend = messageToSend;
    }
}
public struct BroadcastMessageToBLClassicFromDevicesNameId : IZhuLiCommand
{
    public string m_deviceNamedId;
    public string m_messageToSend;

    public BroadcastMessageToBLClassicFromDevicesNameId(string deviceNamedId, string messageToSend)
    {
        m_deviceNamedId = deviceNamedId;
        m_messageToSend = messageToSend;
    }
}
