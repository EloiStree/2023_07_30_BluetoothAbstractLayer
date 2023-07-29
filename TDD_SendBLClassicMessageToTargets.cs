using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDD_SendBLClassicMessageToTargets : MonoBehaviour
{
    public BLClassicWriteLayerMono m_toAffect;
    public string m_macAddressOfDevice="";
    public string m_deviceName="HC-05";

    [TextArea(0,10)]
    public string m_messageToSend;

    [ContextMenu("Send Message to Mac Address")]
    public void SendMessageToDeviceMacAddress()
    {
        if(m_toAffect)
            m_toAffect.SendMessageToMacAddress(m_macAddressOfDevice, m_messageToSend);
    }
    [ContextMenu("Send Message to First with name")]
    public void SendMessageToFirstDeviceFromName()
    {
        if (m_toAffect)
            m_toAffect.SendMessageToFirstDeviceWithName(m_deviceName, m_messageToSend);
    }

    [ContextMenu("Send Message to All with name")]
    public void SendMessageToAllDeviceFromName()
    {
        if (m_toAffect)
            m_toAffect.SendMessageToAllDeviceWithName(m_deviceName, m_messageToSend);
    }
}
