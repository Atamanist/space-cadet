using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractRelay : MonoBehaviour, ISwitchable
{
    public bool IsOn { get; private set; }

    public void Switch(bool isON)
    {
        IsOn = isON;
    }

}
