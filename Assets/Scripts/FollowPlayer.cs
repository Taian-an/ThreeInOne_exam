using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // 宣告要跟隨的目標物件（車子）
    public GameObject player;
    
    // 設定相機相對於車子的後上方偏移量
    private Vector3 offset = new Vector3(0, 5, -7);

    void Start()
    {
        
    }

    // 使用 LateUpdate 可以讓相機在車子移動完後才跟上，完美消除鏡頭抖動
    void LateUpdate()
    {
        // 將相機的位置設定為：車子目前的位置 + 後上方的偏移量
        transform.position = player.transform.position + offset;
    }
}