using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.transform.localPosition = Vector3.zero;
    }
}
