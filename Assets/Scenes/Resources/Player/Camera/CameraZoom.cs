using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.PlayerLoop;

public class CameraZoom : MonoBehaviour
{
    public Camera _myCamera;
    public Transform _target;
    private Rigidbody _rb;
    private float _modify;
    private float _zoom;
    [SerializeField] public float _zoomSpeed;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Zoom();
        transform.LookAt(_target);
    }

    void Zoom()
    {
        _modify = Mathf.Sqrt(_rb.position.y) * 1.5f;
        _zoom = Input.mouseScrollDelta.y;
        Vector3 dir = _myCamera.ScreenPointToRay(Input.mousePosition).direction * _modify;

        if (_zoom < 0 && _rb.position.y < 100)
        {
            _rb.AddForce(new Vector3(0, dir.y * _zoom * _zoomSpeed * _modify, _zoom * _zoomSpeed * _modify));
        }
        else if (_zoom > 0 && _rb.position.y > 2)
        {
            _rb.AddForce(dir * _zoom * _zoomSpeed * _modify);
        }
    }
}
