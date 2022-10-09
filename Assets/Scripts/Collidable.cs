using UnityEngine;

public class Collidable : MonoBehaviour
{
	public GameManager manager;
	public float moveSpeed = 20f;
	public float timeAmount = 1.5f;
	int num1 = 0;
	int num2 = 0;

	void Update()
	{
		
		transform.Translate(moveSpeed * Time.deltaTime , 0, 0);
	}
	void Start()
	{	
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}
