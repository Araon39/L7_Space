// ����������� ������ Score, ������� ��������� MonoBehaviour
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // ��������� ���� ��� ����������� ������ �����
    public TextMeshProUGUI scoreText;

    // ��������� ���� ��� �������� ������� �������� �����
    private GameObject[] rings;

    // ��������� ���� ��� �������� ���������� �����
    private int ring;

    // ����� Start ���������� ����� ������ ����������� �����
    private void Start()
    {
        // ����� ���� �������� � ����� "Ring"
        rings = GameObject.FindGameObjectsWithTag("Ring");

        // ��������� ���������� �����
        ring = rings.Length;

        // ���������� ������ �����
        scoreText.text = ring.ToString();
    }

    // ����� OnTriggerExit ����������, ����� ��������� �������� �������
    private void OnTriggerExit(Collider other)
    {
        // ��������, �������� �� ������ �������
        if (other.gameObject.CompareTag("Ring"))
        {
            // ���������� ���������� �����
            ring--;

            // ���������� ������ �����
            scoreText.text = ring.ToString();

            // ����������� ������� ������
            Destroy(other.gameObject);
        }
    }
}
