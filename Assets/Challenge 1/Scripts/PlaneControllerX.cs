using UnityEngine;

public class PlaneControllerX : MonoBehaviour
{
    public float speed = 15.0f;     // 可微調的前進速度
    public float rotationSpeed = 60.0f; // 可微調的傾斜速度
    public float verticalInput;

    void Start()
    {
    }

    void Update()
    {
        // 獲取上下方向鍵輸入
        verticalInput = Input.GetAxis("Vertical");

        // 修正 1：將 Vector3.back 改為 Vector3.forward 讓飛機向前飛
        // 修正 2：乘上 Time.deltaTime 讓飛機速度降下來
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // 修正 3：在 Rotate 中加入 verticalInput，讓飛機只在按下按鍵時傾斜
        transform.Rotate(Vector3.right * rotationSpeed * verticalInput * Time.deltaTime);
    }
}