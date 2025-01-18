using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����� Score ����������� �� MonoBehaviour � ������������ ��� �������� �����
public class Score : MonoBehaviour
{
    // ���������� ��� �������� ���������� ��������� �����
    private int ring = 0;

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

            // ������� ���������� ��������� ����� � ������� ��� �������
            Debug.Log(ring);
        }
    }
}
