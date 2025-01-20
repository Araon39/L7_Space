using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBulett : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Если пуля столкнулась с объектом, уничиняем объект
            Destroy(other.gameObject);
            // Если пуля столкнулась с объектом, уничтожаем пулю
            Destroy(gameObject);
        }
    }
}
