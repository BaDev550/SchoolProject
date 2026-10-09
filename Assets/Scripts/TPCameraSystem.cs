using System;
using Unity.VisualScripting;
using UnityEngine;

public class TPCameraSystem : MonoBehaviour {
    private Camera _ownerCamera;
    public float _sens = 15.0f;

    void Start() {
        _ownerCamera = GetComponent<Camera>();
        Cursor.visible = false;        
    }

    void Update() {
        Vector3 mousePos = Input.mousePosition;

        //_ownerCamera.transform.rotation.SetEulerRotation((mousePos.normalized * _sens));
    }
}
