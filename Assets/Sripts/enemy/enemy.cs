using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform target;  // Цель, к которой будет двигаться объект
    public float speed;  // Скорость движения
    

    private Rigidbody2D rb;

    void Start()
    {
        target = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();  // Получаем компонент Rigidbody2D
        float temp_speed = Random.Range(-0.3f, 0.3f);
        speed = speed + temp_speed;
    }

    void Update()
    {
            Vector3 direction = (target.position - transform.position).normalized;

            // Расчет движения
            Vector2 movement = direction * speed * Time.deltaTime;

            // Двигаем объект с использованием Rigidbody2D
            rb.MovePosition(rb.position + movement);

    }
}
