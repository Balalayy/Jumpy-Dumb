using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private Transform player;

    // ������� ������ ��� �������� �����������
    private Vector3 cameraPosition;

    private void Start()
    {
        // ���� ������ ������ �� ��� �������� ������� ����� ���������, ������� ��� �����������
        if (!player)
        {
            player = GameObject.FindObjectOfType<Player>().transform;

            // �������� �� ������, ���� ����� �� ��� �� ������
            if (!player)
                Debug.LogError("����� �� ������!");
        }

        // ������������� ��������� ������� ������
        cameraPosition = new Vector3(player.position.x, player.position.y, -10f);
    }

    private void LateUpdate()
    {
        // ��������� ������� ������� ������
        Vector3 targetPosition = new Vector3(player.position.x, player.position.y, -10f);

        // ������� ������� � ����� �������
        cameraPosition = Vector3.Lerp(cameraPosition, targetPosition, Time.deltaTime * 5f); // ����� �������� ����� ���������

        // ���������� ������
        transform.position = cameraPosition;
    }
}