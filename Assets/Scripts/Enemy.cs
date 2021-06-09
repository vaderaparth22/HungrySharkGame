using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector2 moveDirection;

    public void Initialize(Vector2 dir)
    {
        transform.rotation = Quaternion.FromToRotation(transform.right, (Vector2)dir);
    }

    public void RefreshUpdate()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
            gameObject.SetActive(false);    //remove from pool rather than Destroy(gameObject)
    }
}
