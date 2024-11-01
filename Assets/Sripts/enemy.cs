using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform target;  // Цель, к которой будет двигаться объект
    public int speed;  // Скорость движения

    private Rigidbody2D rb;

    void Start()
    {
        target = GameObject.Find("Player").transform;
        rb = GetComponent<Rigidbody2D>();  // Получаем компонент Rigidbody2D
    }

    void Update()
    {
            // Направление к цели
            Vector2 direction = (target.position - transform.position).normalized;

            // Перемещаем объект с учетом физики
            rb.MovePosition(rb.position + direction * speed * Time.deltaTime);

    }
}
