using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISender<T>
{
    void Send(T value);
}
