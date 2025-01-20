using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Скорость движения игрока
    [SerializeField] private int speed = 10;

    // Скорость вращения игрока
    [SerializeField] private int rotationSpeed = 60;

    [SerializeField] private GameObject gameOver;

    // Переменные для хранения горизонтального и вертикального ввода
    private float horizontal;
    private float vertical;

    // Метод Update вызывается один раз за кадр
    
    void Update()
    {
        // Получаем горизонтальный ввод от игрока (например, стрелки влево/вправо или A/D)
        horizontal = Input.GetAxis("Horizontal");

        // Получаем вертикальный ввод от игрока (например, стрелки вверх/вниз или W/S)
        vertical = Input.GetAxis("Vertical");

        // Перемещаем игрока вперед по направлению Vector3.forward, умноженному на скорость и дельта-время
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);

        // Перемещаем игрока вправо по направлению Vector3.right, умноженному на скорость, дельта-время и горизонтальный ввод
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontal);

        // Вращаем игрока вокруг оси Y (вверх) по направлению Vector3.left, умноженному на скорость вращения, дельта-время и вертикальный ввод
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
