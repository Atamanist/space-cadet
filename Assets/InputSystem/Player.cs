using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputMaster _master;
    [SerializeField] private Plunger[] _plunger;
    [SerializeField] private Flipper[] _rightFlipper;
    [SerializeField] private Flipper[] _leftFlipper;


    private void Awake()
    {
        _master = new InputMaster();
        _master.Enable();
        PlungerSettup();
        LeftFlipperSettup();
        RightFlipperSettup();
    }

    private void PlungerSettup()
    {
        foreach (var plunger in _plunger)
        {
            _master.Player.PullPlunger.started += _ctx => plunger.Switch(isON: true);
            _master.Player.PullPlunger.canceled += _ctx => plunger.Switch(isON: false);
        }
    }
    private void LeftFlipperSettup()
    {
        foreach (var leftFlipper in _leftFlipper)
        {
            _master.Player.LeftFlipper.started += _ctx => leftFlipper.Switch(isON: true);
            _master.Player.LeftFlipper.canceled += _ctx => leftFlipper.Switch(isON: false);
        }
    }
    private void RightFlipperSettup()
    {
        foreach (var rightFlipper in _rightFlipper)
        {
            _master.Player.RightFlipper.started += _ctx => rightFlipper.Switch(isON: true);
            _master.Player.RightFlipper.canceled += _ctx => rightFlipper.Switch(isON: false);
        }
    }

}
