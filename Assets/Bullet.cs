using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{

    public float flySpeed; // Biến tốc độ bay

    // Update is called once per frame
    void Update()
    {
        // Lấy vị trí hiện tại
        var newPosition = transform.position;

        // Cộng thêm khoảng di chuyển theo trục Y
        newPosition.y += Time.deltaTime * flySpeed;

        // Cập nhật lại vị trí mới cho viên đạn
        transform.position = newPosition;
    }
}