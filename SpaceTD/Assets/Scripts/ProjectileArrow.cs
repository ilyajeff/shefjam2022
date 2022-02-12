using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileArrow : MonoBehaviour
{
    public static void Create(Vector3 spawnPosition, Vector3 targetPosition)
    {
        Transform arrowTransform = Instantiate(GameAssets.i.pfProjectile, spawnPosition, Quaternion.identity);

        ProjectileArrow projectileArrow = arrowTransform.GetComponent<ProjectileArrow>();
        projectileArrow.Setup(targetPosition);
    }

    private Vector3 targetPosition;

    private void Setup(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;

    }

    private void Update()
    {
        Vector3 moveDir = (targetPosition - transform.position).normalized;

        float moveSpeed = 750f;

        transform.position += moveDir * moveSpeed * Time.deltaTime;

        float destroySelfDistance = 0.5f;

        if (Vector3.Distance(transform.position, targetPosition) < destroySelfDistance)
        {
            Destroy(this.gameObject);
        }
    }
}
