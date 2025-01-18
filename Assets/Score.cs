using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // �������� ��� ��� ������������� TextMeshPro �����������

public class Score : MonoBehaviour
{
    // ���������� ��� �������� ���������� ��������� �����
    private int ring = 0;

    // ������ �� ��������� TextMeshProUGUI ��� ����������� �����
    public TextMeshProUGUI scoreText;

    // ����� OnTriggerExit ����������, ����� ������ �������� ���������� �������
    private void OnTriggerExit(Collider other)
    {
        // ���������, ����� �� ������, ���������� ���������� �������, ��� "Ring"
        if (other.gameObject.CompareTag("Ring"))
        {
            // ����������� ������� �����
            ring++;

            // ���������� ������ ������
            Destroy(other.gameObject);

            // ��������� ����� �� UI
            UpdateScoreText();
        }
    }

    // ����� ��� ���������� ������ ����� �� UI
    private void UpdateScoreText()
    {
        // ���������, ��� ������ �� ��������� TextMeshProUGUI �� ������
        if (scoreText != null)
        {
            // ��������� ����� �� UI
            scoreText.text = "Rings: " + ring.ToString();
        }
    }
}
