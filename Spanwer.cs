using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab1;
    public GameObject Prefab2;
    public float spawn = .5f;

    GameManager manager;
    float TimeSpawn;
    bool spawnPowerup = true;
    

    void Start()
    {
        manager = GetComponent<GameManager>();
    }

    void Update()
    {
        TimeSpawn += Time.deltaTime;
        if (TimeSpawn > spawn)
        {
            GameObject temp;
            if (spawnPowerup)
                temp = Instantiate(Prefab1) as GameObject;
            else
                temp = Instantiate(Prefab2) as GameObject;

            Vector3 position = temp.transform.position;

            position.x = Random.Range(-3f, 3f);//Радиус
            temp.transform.position = position;

            Collidable col = temp.GetComponent<Collidable>();
            col.manager = manager;

            TimeSpawn = 0;
            spawnPowerup = !spawnPowerup;
        }
    }
}
