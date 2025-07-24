using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using extOSC;

/// <summary>
/// Receives a specific message via OSC, and applies it to the proxy phone object in the scene.
/// </summary>
public class BasicOSCHandler : MonoBehaviour
{

    [SerializeField]
    GameObject _originObject;

    [SerializeField]
    GameObject _phoneObject;

    OSCReceiver _thisReceiver;

    Vector3 _relPosition;
    Quaternion _relRotation;

    void Start()
    {
        _thisReceiver = this.GetComponent<OSCReceiver>();
        _thisReceiver.Bind("/phone/pose",MoveFromOSC);
    }

    public void MoveFromOSC(OSCMessage message)
    {
        _relPosition = new Vector3(message.Values[0].FloatValue, message.Values[1].FloatValue, message.Values[2].FloatValue);
        _relRotation = new Quaternion(message.Values[3].FloatValue, message.Values[4].FloatValue, message.Values[5].FloatValue, message.Values[6].FloatValue);

        _phoneObject.transform.position = _originObject.transform.TransformPoint(_relPosition);
        _phoneObject.transform.rotation = _originObject.transform.rotation * _relRotation;
    }
}
