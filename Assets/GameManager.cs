// ����������� ������ GameManager, ������� ��������� MonoBehaviour
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // ��������� ���� ��� �������� �������� ������
    private int currentLevel = 0;

    // ����� Update ���������� ������ ����
    void Update()
    {
        // ��������, ������� �� ��� ������
        if (CheckRings())
        {
            // ���� ��� ������ �������, ��������� � ���������� ������
            NextLevel();
        }
    }

    // ����� ��� ��������, ������� �� ��� ������
    bool CheckRings()
    {
        // ����� ���� �������� � ����� "Ring"
        GameObject[] rings = GameObject.FindGameObjectsWithTag("Ring");

        // ���� ��� �������� � ����� "Ring", ������ ��� ������ �������
        return rings.Length == 0;
    }

    // ����� ��� �������� �� ��������� �������
    void NextLevel()
    {
        // ���������� �������� ������ �� 1
        currentLevel = SceneManager.GetActiveScene().buildIndex + 1;

        // �������� ���������� ������
        SceneManager.LoadScene(currentLevel);
    }
}
