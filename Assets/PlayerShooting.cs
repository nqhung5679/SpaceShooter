using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    // Các biến bắt buộc để không lỗi file Bonus.cs
    public static PlayerShooting instance;
    public int weaponPower = 1;
    public int maxweaponPower = 5;

    public GameObject bulletPrefabs;
    public float shootingInterval = 0.2f;
    private float lastBulletTime;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // Giữ chuột trái
        {
            if (Time.time - lastBulletTime > shootingInterval)
            {
                Shoot();
                lastBulletTime = Time.time;
            }
        }
    }

    void Shoot()
    {
        if (bulletPrefabs != null)
        {
            Instantiate(bulletPrefabs, transform.position, transform.rotation);
        }
    }
}