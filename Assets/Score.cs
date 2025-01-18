using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Класс Score наследуется от MonoBehaviour и используется для подсчета очков
public class Score : MonoBehaviour
{
    // Переменная для хранения количества собранных колец
    private int ring = 0;

    // Метод OnTriggerExit вызывается, когда объект покидает триггерную область
    private void OnTriggerExit(Collider other)
    {
        // Проверяем, имеет ли объект, покинувший триггерную область, тег "Ring"
        if (other.gameObject.CompareTag("Ring"))
        {
            // Увеличиваем счетчик колец
            ring++;

            // Уничтожаем объект кольца
            Destroy(other.gameObject);

            // Выводим количество собранных колец в консоль для отладки
            Debug.Log(ring);
        }
    }
}
