using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float bounds = 3f;
	public float strafeSpeed = 4f;
	public float phaseCooldown = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * strafeSpeed;

		Vector3 position = transform.position;
		position.x += xMove;
		//position.x = Mathf.Clamp(position.x, -bounds, bounds);
		transform.position = position;
    }
}
