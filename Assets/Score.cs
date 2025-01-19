// Определение класса Score, который наследует MonoBehaviour
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Публичное поле для отображения текста счета
    public TextMeshProUGUI scoreText;

    // Приватное поле для хранения массива объектов колец
    private GameObject[] rings;

    // Приватное поле для хранения количества колец
    private int ring;

    // Метод Start вызывается перед первым обновлением кадра
    private void Start()
    {
        // Поиск всех объектов с тегом "Ring"
        rings = GameObject.FindGameObjectsWithTag("Ring");

        // Установка количества колец
        ring = rings.Length;

        // Обновление текста счета
        scoreText.text = ring.ToString();
    }

    // Метод OnTriggerExit вызывается, когда коллайдер покидает триггер
    private void OnTriggerExit(Collider other)
    {
        // Проверка, является ли объект кольцом
        if (other.gameObject.CompareTag("Ring"))
        {
            // Уменьшение количества колец
            ring--;

            // Обновление текста счета
            scoreText.text = ring.ToString();

            // Уничтожение объекта кольца
            Destroy(other.gameObject);
        }
    }
}
