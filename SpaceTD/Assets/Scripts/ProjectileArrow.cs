using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileArrow : MonoBehaviour
{
    public static void Create(Vector3 spawnPosition)
    {
        Instantiate(GameAssets.i.pfProjectile, spawnPosition, Quaternion.identity);
    }

    private void Update()
    {


    }
}
