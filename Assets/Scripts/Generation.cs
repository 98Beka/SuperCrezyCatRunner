using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Радиус рандома, от _ до _:")]
    [SerializeField] float RangeStart;
    [SerializeField] float RangeFinish;

    [Header("Раз в какое время спавнить префаб:")]
    [SerializeField] float spawnTime;//spawnCycle

    //[Header("Префаб который надо заспавнить:")]
    [Header("Все виды префабов:")]

    [SerializeField] List<GameObject> Prefabs = new List<GameObject>();
    //[SerializeField] GameObject Prefab;

    int prefabRandomIndex;


    [Header("Рандом какой координаты генерировать:")]
    public bool isX;
    public bool isY;
    public bool isZ;

    [Header("Генерировать X и Z?")]    

    public bool isXAndZ;

    [Header("Если генерировать X и Z, то:")]      
    [Header("Радиус рандома X, от _ до _:")]  
    [SerializeField] float RangeStartX;
    [SerializeField] float RangeFinishX;

    [Header("Радиус рандома Z, от _ до _:")] 

    [SerializeField] float RangeStartZ;
    [SerializeField] float RangeFinishZ;

    float posX;
    float posY;
    float posZ;

    [Header("Какая координата и значение этой ")]
    [Header("координаты Вы определить на постоянное сами:")]
    public bool MyX;
    public bool MyY;
    public bool MyZ;

    [Header("Значение этой координаты:")]
    [SerializeField] float MyXFloat;
    [SerializeField] float MyYFloat;
    [SerializeField] float MyZFloat;

    float timeTimer;

    //Spawner spawnerScript;


    void Start()
    {
        //spawnerScript = FindObjectOfType<Spawner>();
        //spawnerScript = GetComponent<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isX)
        {
            isY = false; isZ = false;
        }
        if(isY)
        {
            isX = false; isZ = false;
        }
        if(isZ)
        {
            isX = false; isY = false;
        }
        timeTimer += Time.deltaTime;
        if(timeTimer > spawnTime)
        {
            if(isX)
            {
                posX = Random.Range(RangeStart, RangeFinish);
            }
            if(isY)
            {
                posY = Random.Range(RangeStart, RangeFinish);
            }
            if(isZ)
            {
                posZ = Random.Range(RangeStart, RangeFinish);
            }
            if(isXAndZ)
            {
                posX = Random.Range(RangeStartX, RangeFinishX);
                posZ = Random.Range(RangeStartZ, RangeFinishZ);
            }
            if(MyX)
            {
                posX = MyXFloat;
            }
            if(MyY)
            {
                posY = MyYFloat;
            }
            if(MyZ)
            {
                posZ = MyZFloat;
            }

            prefabRandomIndex = Random.Range(0, Prefabs.Count);

            timeTimer = 0f;

            //spawnerScript.GetComponent<Spawner>().Spawn(Prefab, posX, posY, posZ);
            Spawn(Prefabs[prefabRandomIndex], posX, posY, posZ);
        }


    }
    public void Spawn(GameObject Object, float posX, float posY, float posZ)
    {
        GameObject spawner;
        spawner = Instantiate(Object, new Vector3(posX, posY, posZ), Quaternion.identity);// as GameObject;
        Vector3 position = spawner.transform.position;
    }
}
