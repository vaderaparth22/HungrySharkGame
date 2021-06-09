using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector2 moveDirection;

    public void Initialize(Vector2 dir)
    {
        this.moveDirection = dir;
    }

    public void RefreshUpdate()
    {
        transform.position = moveDirection * speed;
    }
}
