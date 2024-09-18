using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyBehaviour : MonoBehaviour
{
    public Transform player;
    public float movementSpeed = 5f;
    public float attackRadius = 1.5f;
    public LayerMask obstacleLayer;

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Получаем направление до игрока
        Vector2 direction = (Vector2)player.position - rb.position;

        // Проверяем расстояние до игрока
        if (direction.magnitude > attackRadius)
        {
            // Проверяем наличие препятствий на пути
            RaycastHit2D hit = Physics2D.Raycast(rb.position, direction, direction.magnitude, obstacleLayer);
            if (hit.collider == null)
            {
                // Нет препятствий, двигаемся к игроку
                direction.Normalize();
                rb.MovePosition(rb.position + direction * movementSpeed * Time.deltaTime);
            }
        }

        else
        {
            // Атакуем игрока в ближнем бою
            AttackPlayer();
        }
    }

    void AttackPlayer()
    {
        // Реализуйте здесь логику атаки игрока
        Debug.Log("Атакуем игрока!");
    }
}
