using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // �������� �������� ������
    [SerializeField] private int speed = 10;

    // �������� �������� ������
    [SerializeField] private int rotationSpeed = 60;

    [SerializeField] private GameObject gameOver;

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
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);

        // ���������� ������ ������ �� ����������� Vector3.right, ����������� �� ��������, ������-����� � �������������� ����
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);

        // ������� ������ ������ ��� Y (�����) �� ����������� Vector3.left, ����������� �� �������� ��������, ������-����� � ������������ ����
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime * vertical);

        if (transform.position.z > 100)
        {
            gameOver.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameOver.SetActive(true);
        }
    }
}
