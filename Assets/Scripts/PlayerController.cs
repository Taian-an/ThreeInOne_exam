using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 宣告控制前進與轉彎速度的變數
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    
    // 宣告儲存鍵盤輸入數值的變數
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }

    void Update()
    {
        // 1. 獲取玩家的鍵盤輸入數值
        horizontalInput = Input.GetAxis("Horizontal"); // 左右方向鍵 (A/D)
        forwardInput = Input.GetAxis("Vertical");     // 上下方向鍵 (W/S)

        // 2. 依據輸入讓車子前進或後退 (油門/煞車)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // 3. 依據輸入讓車子進行旋轉轉彎 (而不是單純的左右平移)
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
