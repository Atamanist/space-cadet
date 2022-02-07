using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshoot : MonoBehaviour, IPushable, IReturnable, ISwitchable
{
    [SerializeField] private Flipper[] _flipers;
    [SerializeField] private float _timer;

    public void Switch(bool isON)
    {
        Push();
    }

    public void Push()
    {
        foreach (Flipper detector in _flipers)
        {
            detector.Switch(true);
            StartCoroutine(WaitAndDo(_timer));
        }
    }

    IEnumerator WaitAndDo(float time)
    {
        yield return new WaitForSeconds(time);
        Return();
    }
    public void Return()
    {
        foreach (Flipper detector in _flipers)
        {
            detector.Switch(false);
        }
    }
}
