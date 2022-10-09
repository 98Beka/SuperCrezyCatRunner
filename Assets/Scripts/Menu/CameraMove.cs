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

    private void Update() {
        /*if (_startGame)
        {
            _camera.transform.position = Vector3.Lerp(startPonint.position, endPoint.position, 0.005f );
            _camera.transform.rotation = Quaternion.Lerp(startPonint.rotation, endPoint.rotation, 0.005f );
        }

        if(Input.GetKeyDown(KeyCode.F))
        {
            _startGame = true;
        }*/
    }

    public void StartGame()
    {
        StartCoroutine(StartGame2());
    }

    public IEnumerator StartGame2()
    {
        while(true)
        {
             _camera.transform.position = Vector3.Lerp(startPonint.position, endPoint.position, 0.05f );
            _camera.transform.rotation = Quaternion.Lerp(startPonint.rotation, endPoint.rotation, 0.05f );
            yield return new WaitForSeconds(0.01f);
        }
           
        
        yield return null;
       
    }

}
