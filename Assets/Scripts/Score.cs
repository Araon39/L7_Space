// ������������ ������������ ����
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// ����������� ������ Score, ������� ��������� MonoBehaviour
public class Score : MonoBehaviour
{
    // ��������� ���� ��� ����������� ������ �������� �����
    public TextMeshProUGUI scoreText;

    // ��������� ���� ��� ����������� ������ ������� �����
    public TextMeshProUGUI bestScoreText;

    // ��������� ���� ��� �������� ������� �������� �����
    private GameObject[] rings;

    // ��������� ���� ��� �������� ���������� �����
    private int ring;

    // ��������� ����������� ���� ��� �������� ������� �����
    public static int countRings = 0;

    // ����� Start ���������� ����� ������ ����������� �����
    private void Start()
    {
        // ����� ���� �������� � ����� "Ring"
        rings = GameObject.FindGameObjectsWithTag("Ring");

        // ��������� ���������� �����
        ring = rings.Length;

        // ���������� ������ �������� �����
        scoreText.text = ring.ToString();

        // ���������� ������ ������� �����
        bestScoreText.text = countRings.ToString();
    }

    // ����� OnTriggerExit ����������, ����� ��������� �������� �������
    private void OnTriggerExit(Collider other)
    {
        // ��������, �������� �� ������ �������
        if (other.gameObject.CompareTag("Ring"))
        {
            // ���������� �������� ��������� �����
            countRings++;

            // ���������� ���������� �����
            ring--;

            // ���������� ������ �������� �����
            scoreText.text = ring.ToString();

            // ���������� ������ ������� �����
            bestScoreText.text = countRings.ToString();

            // ����������� ������� ������
            Destroy(other.gameObject);
        }
    }
}
