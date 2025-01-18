using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int currentLevel = 0; // ������� �������

    // ����� ���������� ��� ����������� ������� � ����� "Ring"
    public void OnRingCollected()
    {
        // ���������, �������� �� ������
        if (GameObject.FindGameObjectsWithTag("Ring").Length == 0)
        {
            LoadNextLevel(); // ��������� ��������� �������
        }
    }

    // ����� ��� �������� ���������� ������
    private void LoadNextLevel()
    {
        currentLevel++;
        if (currentLevel >= SceneManager.sceneCountInBuildSettings)
        {
            currentLevel = 0; // ���������� �������, ���� ����� �� �������
        }
        SceneManager.LoadScene(currentLevel);
    }
}
