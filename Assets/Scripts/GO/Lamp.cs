using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Light))]
public class Lamp : MonoBehaviour,ISwitchable,IWaitAndDo
{
    private Light _light;
    [SerializeField] private float _timer;


    public void Switch(bool isON)
    {
        _light.enabled = isON;
        StartCoroutine(WaitAndDo(_timer));

    }

    public IEnumerator WaitAndDo(float time)
    {
        yield return new WaitForSeconds(time);
        _light.enabled = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        _light = GetComponent<Light>();
        _light.enabled = false;
    }

}
