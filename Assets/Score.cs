using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Добавьте это для использования TextMeshPro компонентов

public class Score : MonoBehaviour
{
    // Переменная для хранения количества собранных колец
    private int ring = 0;

    // Ссылка на компонент TextMeshProUGUI для отображения очков
    public TextMeshProUGUI scoreText;

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

            // Обновляем текст на UI
            UpdateScoreText();
        }
    }

    // Метод для обновления текста очков на UI
    private void UpdateScoreText()
    {
        // Проверяем, что ссылка на компонент TextMeshProUGUI не пустая
        if (scoreText != null)
        {
            // Обновляем текст на UI
            scoreText.text = "Rings: " + ring.ToString();
        }
    }
}
