using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;
    public int spawnCount;
    public Queue<GameObject> bulletList = new Queue<GameObject>();

    //TODO: create a structure to contain a collection of bullets

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pools

        for (int i = 0; i < spawnCount; i++)
        {
            GameObject obj = Instantiate(bullet);
            obj.SetActive(false);
            bulletList.Enqueue(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        GameObject obj = bulletList.Dequeue();
        obj.SetActive(true);
        return obj;
    }

    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
              bullet.SetActive(false);
              bulletList.Enqueue(bullet);

    }

}
