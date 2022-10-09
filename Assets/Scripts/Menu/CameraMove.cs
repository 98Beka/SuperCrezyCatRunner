using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform endPoint;
    private Camera _camera;
    private bool _startGame = false;

    private void Start() 
    {
        _camera = GetComponent<Camera>();
    }

    public void StartGame()
    {
        while(true)
        {
            _camera.transform.position = Vector3.Lerp(_camera.transform.position, endPoint.position, 0.05f );
            _camera.transform.rotation = Quaternion.Lerp(_camera.transform.rotation, endPoint.rotation, 0.05f );
            if( _camera.transform.position == endPoint.position)
                break;
        }

    }

    
}
