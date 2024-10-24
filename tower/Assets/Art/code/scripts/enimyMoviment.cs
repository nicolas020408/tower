using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovimenty : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float movespeed = 2f;

    private Transform target;
    private int pathIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        target = LevelManager.main.path[pathIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f)
        {
            pathIndex++;
            if (pathIndex == LevelManager.main.path.Length)
            {
                EnemySpawner.onEnemyDestroy.Invoke();
                Destroy(gameObject);
                return;
            }
            else
            {
                target = LevelManager.main.path[pathIndex];
            }
        }

    }
    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;
        rb.velocity = direction * movespeed;
    }
}