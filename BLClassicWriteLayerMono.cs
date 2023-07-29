using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLClassicWriteLayerMono : MonoBehaviour
{

    public IZhuLiCommandEvent m_onRequestAction;
    public bool m_useStatiZhuLi;
    public void SendMessageToMacAddress(string macAddress, string message)
    {

        IZhuLiCommand cmd = new SendMessageToBLClassicToMacId(macAddress, message);
        if(m_useStatiZhuLi)
        ZhuLi.DoTheThing(cmd);
        m_onRequestAction.Invoke(cmd);
    }
    public void SendMessageToFirstDeviceWithName(string deviceName, string message)
    {

        IZhuLiCommand cmd = new SendMessageToBLClassicToMacId(deviceName, message);
        if (m_useStatiZhuLi)
            ZhuLi.DoTheThing(cmd);
        m_onRequestAction.Invoke(cmd);
    }
    public void SendMessageToAllDeviceWithName(string deviceName, string message)
    {

        IZhuLiCommand cmd = new BroadcastMessageToBLClassicFromDevicesNameId(deviceName, message );
        if (m_useStatiZhuLi)
            ZhuLi.DoTheThing(cmd);
        m_onRequestAction.Invoke(cmd);
    }



}
