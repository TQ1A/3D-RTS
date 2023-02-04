using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barracks : MonoBehaviour
{
    public GameObject _objToSpawn;

    private void OnMouseDown()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(_objToSpawn, gameObject.transform);
        }
    }
}
