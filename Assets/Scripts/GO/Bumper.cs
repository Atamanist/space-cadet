using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour, IPushable, ISwitchable,IReturnable
{
    [SerializeField] private Rigidbody _rbPull;
    [SerializeField] private Rigidbody _rbBase;
    [SerializeField] private float _rbPullHeight;
    [SerializeField] private float _rbPushHeight;
    [SerializeField] private Detector _detector;
    private Vector3 _startPositions;

    private bool _isOn;

    private void Start()
    {
        _startPositions = new Vector3(0, _rbPushHeight, 0);
        Switch(false);
        Return();
    }

    public void Switch(bool isON)
    {
        _isOn = isON;
        _rbPull.isKinematic = !_isOn;
        _rbPull.velocity = Vector3.zero;
    }

    public void Return()
    {
        _rbPull.transform.localPosition = _startPositions;
    }

    void FixedUpdate()
    {
        if (_isOn)
            Push();
    }

    public void Push()
    {
        if (_rbPull.transform.localPosition.y < _rbPullHeight)
        {
            Switch(false);
            Return();
        }
    }
}
