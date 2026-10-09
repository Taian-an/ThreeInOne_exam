using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    public float propellerSpeed = 1000.0f; // 旋轉速度

    void Update()
    {
        // 繞著 Z 軸（Vector3.forward）每秒快速旋轉
        transform.Rotate(Vector3.forward * propellerSpeed * Time.deltaTime);
    }
}