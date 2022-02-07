using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private InputMaster _master;
    [SerializeField] private Plunger _plunger;
    [SerializeField] private Flipper _rightFlipper;
    [SerializeField] private Flipper _leftFlipper;
    [SerializeField] private Bumper _pumper;


    private void Awake()
    {
        _master = new InputMaster();
        _master.Enable();
        _master.Player.PullPlunger.started += _ctx => _plunger.Switch(isON:true);
        _master.Player.PullPlunger.canceled += _ctx => _plunger.Switch(isON: false);
        _master.Player.RightFlipper.started += _ctx => _rightFlipper.Switch(isON: true);
        _master.Player.RightFlipper.canceled += _ctx => _rightFlipper.Switch(isON: false);
        _master.Player.LeftFlipper.started += _ctx => _leftFlipper.Switch(isON: true);
        _master.Player.LeftFlipper.canceled += _ctx => _leftFlipper.Switch(isON: false);


        //_master.Player.PullPlunger.started += _ctx => _pumper.Pull();



    }
}
