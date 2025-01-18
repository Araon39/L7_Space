using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int currentLevel = 0; // Текущий уровень

    // Метод вызывается при уничтожении объекта с тегом "Ring"
    public void OnRingCollected()
    {
        // Проверяем, остались ли кольца
        if (GameObject.FindGameObjectsWithTag("Ring").Length == 0)
        {
            LoadNextLevel(); // Загружаем следующий уровень
        }
    }

    // Метод для загрузки следующего уровня
    private void LoadNextLevel()
    {
        currentLevel++;
        if (currentLevel >= SceneManager.sceneCountInBuildSettings)
        {
            currentLevel = 0; // Сбрасываем уровень, если вышли за пределы
        }
        SceneManager.LoadScene(currentLevel);
    }
}
