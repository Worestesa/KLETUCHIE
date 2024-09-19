using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] float TimeDamage;
    float timeColdoun;
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
        // �������� ����������� �� ������
        Vector2 direction = (Vector2)player.position - rb.position;

        // ��������� ���������� �� ������
        if (direction.magnitude > attackRadius)
        {
            // ��������� ������� ����������� �� ����
            RaycastHit2D hit = Physics2D.Raycast(rb.position, direction, direction.magnitude, obstacleLayer);
            if (hit.collider == null)
            {
                // ��� �����������, ��������� � ������
                direction.Normalize();
                rb.MovePosition(rb.position + direction * movementSpeed * Time.deltaTime);
            }
        }

        else
        {
            // ������� ������ � ������� ���
            AttackPlayer();
        }
    }

    void AttackPlayer()
    {
        // ���������� ����� ������ ����� ������
        Debug.Log("������� ������!");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.GetComponent<HPPlaeyr>() != null)
        {
            Debug.Log("HI!!!");
            timeColdoun = timeColdoun + 1 / 50f;
            if (timeColdoun > TimeDamage)
            {
                timeColdoun = 0;
                collision.transform.GetComponent<HPPlaeyr>().damage(20);
            }
        }
    }
}
