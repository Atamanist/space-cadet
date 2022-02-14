using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour,ISwitchable,ISender<bool>
{
    public void Send(bool value)
    {
        throw new System.NotImplementedException();
    }

    public void Switch(bool isON)
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
