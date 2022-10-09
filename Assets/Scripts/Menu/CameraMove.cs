using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform startPonint;
    [SerializeField] Transform endPoint;
    private Camera _camera;
    private bool _startGame = false;

    private void Start() 
    {
        _camera = GetComponent<Camera>();
    }

    public void StartGame()
    {
        StartCoroutine(MovingCamera());
    }

    public IEnumerator MovingCamera()
    {
        while(true)
        {
            _camera.transform.position = Vector3.Lerp(startPonint.position, endPoint.position, 0.05f );
            _camera.transform.rotation = Quaternion.Lerp(startPonint.rotation, endPoint.rotation, 0.05f );
            if( _camera.transform.position == startPonint.position)
                break;
        }
        yield return null;
    }

}
