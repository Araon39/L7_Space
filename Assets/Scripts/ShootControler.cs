using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    // Объект, представляющий пулю
    public GameObject bullet;
    // Позиция левого крыла
    public Transform leftWing;
    // Позиция правого крыла
    public Transform rightWing;

    void Update()
    {
        // Проверяем, нажата ли левая кнопка мыши
        if (Input.GetMouseButtonDown(0))
        {
            // Создаем пулю в позиции левого крыла с той же ориентацией, что и у пули
            Instantiate(bullet, leftWing.position, bullet.transform.rotation);

            // Создаем пулю в позиции правого крыла с той же ориентацией, что и у пули
            Instantiate(bullet, rightWing.position, bullet.transform.rotation);
        }
    }
}

