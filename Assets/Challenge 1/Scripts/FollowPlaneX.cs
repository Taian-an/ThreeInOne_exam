using UnityEngine;

public class FollowPlaneX : MonoBehaviour
{
    public GameObject plane;
    // 修正 5：宣告並初始化側面跟隨的偏移量
    private Vector3 offset = new Vector3(30, 0, 10); 

    void Start()
    {
    }

    // 使用 LateUpdate 確保鏡頭平滑
    void LateUpdate()
    {
        // 修正 5：更新相機位置
        transform.position = plane.transform.position + offset;
    }
}