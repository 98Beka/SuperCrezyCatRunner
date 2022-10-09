using UnityEngine;

public class GameManager : MonoBehaviour
{
	public TextureScroller ground;
	public float gameTime = 10;

	float totalTimeElapsed = 0;
	bool isGameOver = false;

	void Update()
	{
		if (isGameOver)
			return; 

		totalTimeElapsed += Time.deltaTime;
		gameTime -= Time.deltaTime;

		if (gameTime <= 0)
			isGameOver = true;
	}




	

}
