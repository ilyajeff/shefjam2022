using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour

{
    // Start is called before the first frame update
    public static void Create(Vector3 startPoint)
    {
        Instantiate(GameAssets.i.pfEnemy, startPoint, Quaternion.identity);
    }

    // Update is called once per frame
    private void Update()
    {

    }


}
