using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Префаб который надо заспавнить:")]
    [SerializeField] GameObject Object;
    [Header("Нужные координаты:")]
    [SerializeField] float posX;
    [SerializeField] float posY;
    [SerializeField] float posZ;
    public void Spawn()
    {
        GameObject spawner;
        spawner = Instantiate(Object, new Vector3(posX, posY, posZ), Quaternion.identity);// as GameObject;
        Vector3 position = spawner.transform.position;
    }
}
