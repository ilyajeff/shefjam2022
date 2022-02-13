using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey;
using CodeMonkey.Utils;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public static void Create(Vector3 startPosition)
    {
        Instantiate(GameAssets.i.pfEnemy, startPosition, Quaternion.identity);
    }

    // Update is called once per frame
    private void Update()
    {
    
    }
}
