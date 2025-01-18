using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �������� �������� ������
    private int speed = 10;

    // �������� �������� ������
    private int rotationSpeed = 60;

    // ���������� ��� �������� ��������������� � ������������� �����
    private float horizontal;
    private float vertical;

    // ����� Update ���������� ���� ��� �� ����
    
    void Update()
    {
        // �������� �������������� ���� �� ������ (��������, ������� �����/������ ��� A/D)
        horizontal = Input.GetAxis("Horizontal");

        // �������� ������������ ���� �� ������ (��������, ������� �����/���� ��� W/S)
        vertical = Input.GetAxis("Vertical");

        // ���������� ������ ������ �� ����������� Vector3.forward, ����������� �� �������� � ������-�����
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // ���������� ������ ������ �� ����������� Vector3.right, ����������� �� ��������, ������-����� � �������������� ����
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);

        // ������� ������ ������ ��� Y (�����) �� ����������� Vector3.left, ����������� �� �������� ��������, ������-����� � ������������ ����
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * vertical);
    }
}
