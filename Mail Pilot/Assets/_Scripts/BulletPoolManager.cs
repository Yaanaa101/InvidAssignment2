using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;

    //TODO: create a structure to contain a collection of bullets

   public List<GameObject> bulletObject;
    //pool consists of 6 bullets
    public int amountPool = 6;

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool

        //makes a collection of bullets
      bulletObject = new List<GameObject>();
      for (int i = 0; i < amountPool; i++)
      {

          bullet.SetActive(false);
          //adds objects to pool
          bulletObject.Add(Instantiate(bullet));
      }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal static void ResetBullet()
    {
        throw new NotImplementedException();
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
   {
        GameObject tempBullet = bulletObject[0];
        tempBullet.SetActive(true);
        bulletObject.RemoveAt(0);
       return tempBullet;
   }
    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        bulletObject.Add(bullet);
        bullet.SetActive(false);

    }
}
