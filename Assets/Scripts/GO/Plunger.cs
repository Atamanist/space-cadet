using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Plunger : MonoBehaviour, IPullable, ISwitchable
{
    [SerializeField] private float _thrust;
    [SerializeField] private Rigidbody _rbPull;
    [SerializeField] private Rigidbody _rbBase;
    [SerializeField] private float _rbPullHeight;
    private bool _isOn = false;

    public void Switch(bool isON)
    {
        _isOn = isON;
        _rbPull.isKinematic = _isOn;
        _rbPull.velocity = Vector3.zero;
    }

    void FixedUpdate()
    {
        if (_isOn)
            Pull();
    }

    public void Pull()
    {
        if (_rbPull.transform.localPosition.y > _rbPullHeight)
        {
            _rbPull.MovePosition(Vector3.Lerp(_rbPull.transform.position, _rbBase.transform.position, Time.deltaTime * _thrust));
        }
    }
}
