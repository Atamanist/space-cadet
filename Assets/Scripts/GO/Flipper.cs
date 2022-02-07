using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipper : MonoBehaviour, ISwitchable
{
    [SerializeField] private HingeJoint _joint;
    [SerializeField] private float _spring;
    [SerializeField] private float _damping;
    [SerializeField] private float _motorVelocity;
    [SerializeField] private float _motorForce;
    private JointSpring _structurSpring=new JointSpring();
    private JointMotor _structurMotor=new JointMotor();

    void Awake()
    {
        _structurSpring.spring = _spring;
        _structurSpring.damper = _damping;

        _structurMotor.targetVelocity = _motorVelocity;
        _structurMotor.force = _motorForce;

        _joint.spring = _structurSpring;
        _joint.motor = _structurMotor;

        _joint.useSpring = true;
    }

    public void Switch(bool isON)
    {
        _joint.useMotor = isON;
        _joint.useSpring = !_joint.useMotor;
    }
}
