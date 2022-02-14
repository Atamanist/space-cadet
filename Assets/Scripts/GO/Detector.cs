using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Detector : MonoBehaviour, ISender<bool>
{
    [Header("Need ISwitchable")]
    [SerializeField] private List<GameObject> _switcherGameObjects = new List<GameObject>();
    private List<ISwitchable> _switches = new List<ISwitchable>();


    private void Start()
    {
        foreach (var switcher in _switcherGameObjects)
            if(switcher.GetComponent<ISwitchable>() != null)
                _switches.Add(switcher.GetComponent<ISwitchable>());

    }

    public void Send(bool value)
    {
        foreach (var switcher in _switches)
            switcher.Switch(value);
    }

    private void OnCollisionEnter(Collision collision) => DetectIDetectedOn(collision);

    private void OnCollisionStay(Collision collision) => DetectIDetectedOn(collision);

    //private void OnCollisionExit(Collision collision)=>DetectIDetectedOff(collision);

    private void DetectIDetectedOn(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<IDetectable>(out IDetectable component))
        {
            Send(true);
        }
    }

    private void DetectIDetectedOff(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<IDetectable>(out IDetectable component))
        {
            Send(false);
        }
    }

}
