using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt_lock : MonoBehaviour
{
    public Transform _target;

    private void Update()
    {
        Lock();
    }

    void Lock()
    {
        transform.position = new Vector3(_target.position.x, 0, _target.position.z+5f);
    }
}
