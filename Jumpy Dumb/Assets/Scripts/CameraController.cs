using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform player;

    // Позиция камеры для плавного перемещения
    private Vector3 cameraPosition;

    private void Start()
    {
        // Если объект игрока не был назначен вручную через инспектор, находим его динамически
        if (!player)
        {
            player = GameObject.FindObjectOfType<Player>().transform;

            // Проверка на случай, если игрок всё ещё не найден
            if (!player)
                Debug.LogError("Игрок не найден!");
        }

        // Устанавливаем начальную позицию камеры
        cameraPosition = new Vector3(player.position.x, player.position.y, -10f);
    }

    private void LateUpdate()
    {
        // Обновляем целевую позицию камеры
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, -10f);

        // Плавный переход к новой позиции
        cameraPosition = Vector3.Lerp(cameraPosition, targetPosition, Time.deltaTime * 5f); // Время перехода можно настроить

        // Перемещаем камеру
        transform.position = cameraPosition;
    }
}