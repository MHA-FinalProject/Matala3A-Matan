using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollideBoom : MonoBehaviour
{

    [SerializeField] private GameObject explotion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(explotion, transform.position , Quaternion.identity);
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
