// Используемые пространства имен
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Определение класса Score, который наследует MonoBehaviour
public class Score : MonoBehaviour
{
    // Публичное поле для отображения текста текущего счета
    public TextMeshProUGUI scoreText;

    // Публичное поле для отображения текста лучшего счета
    public TextMeshProUGUI bestScoreText;

    // Приватное поле для хранения массива объектов колец
    private GameObject[] rings;

    // Приватное поле для хранения количества колец
    private int ring;

    // Публичное статическое поле для хранения лучшего счета
    public static int countRings = 0;

    // Метод Start вызывается перед первым обновлением кадра
    private void Start()
    {
        // Поиск всех объектов с тегом "Ring"
        rings = GameObject.FindGameObjectsWithTag("Ring");

        // Установка количества колец
        ring = rings.Length;

        // Обновление текста текущего счета
        scoreText.text = ring.ToString();

        // Обновление текста лучшего счета
        bestScoreText.text = countRings.ToString();
    }

    // Метод OnTriggerExit вызывается, когда коллайдер покидает триггер
    private void OnTriggerExit(Collider other)
    {
        // Проверка, является ли объект кольцом
        if (other.gameObject.CompareTag("Ring"))
        {
            // Увеличение счетчика собранных колец
            countRings++;

            // Уменьшение количества колец
            ring--;

            // Обновление текста текущего счета
            scoreText.text = ring.ToString();

            // Обновление текста лучшего счета
            bestScoreText.text = countRings.ToString();

            // Уничтожение объекта кольца
            Destroy(other.gameObject);
        }
    }
}
