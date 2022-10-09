using UnityEngine;

public class TextureScroller : MonoBehaviour
{
	public float speed = .5f;
	
	Renderer mesh;
	float offset;

	void Start()
	{
		mesh = GetComponent<Renderer>();
	}

	void Update()
	{
		offset += Time.deltaTime * speed;
		if (offset > 1)
			offset -= 1;
		mesh.material.mainTextureOffset = new Vector2(0, offset);
	}
}
