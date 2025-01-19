// Определение класса GameManager, который наследует MonoBehaviour
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Приватное поле для хранения текущего уровня
    private int currentLevel = 0;

    // Метод Update вызывается каждый кадр
    void Update()
    {
        // Проверка, собраны ли все кольца
        if (CheckRings())
        {
            // Если все кольца собраны, переходим к следующему уровню
            NextLevel();
        }
    }

    // Метод для проверки, собраны ли все кольца
    bool CheckRings()
    {
        // Поиск всех объектов с тегом "Ring"
        GameObject[] rings = GameObject.FindGameObjectsWithTag("Ring");

        // Если нет объектов с тегом "Ring", значит все кольца собраны
        return rings.Length == 0;
    }

    // Метод для перехода на следующий уровень
    void NextLevel()
    {
        // Увеличение текущего уровня на 1
        currentLevel = SceneManager.GetActiveScene().buildIndex + 1;

        // Загрузка следующего уровня
        SceneManager.LoadScene(currentLevel);
    }
}
