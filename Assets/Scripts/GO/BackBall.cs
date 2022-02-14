using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<IDetectable>(out IDetectable component)&& other.gameObject.TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            rb.velocity = Vector3.zero;
            other.gameObject.transform.localPosition = Vector3.zero;

        }
    }
}
