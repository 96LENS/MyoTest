using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 蝶の移動を制御するスクリプト。蝶のオブジェクトに直接アタッチして使用。
/// </summary>
public class MoveButterfly : MonoBehaviour
{
    //=====================================================================================================================
    // 変数
    //=====================================================================================================================
    public float moveSpeed = 1f;
    public float rotateSpeed = 1f;


    //=====================================================================================================================
    // 関数
    //=====================================================================================================================

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void UpdatePosition()
    {
        this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }

    public void UpdateRotation(Vector3 rotation)
    {
        this.gameObject.transform.rotation *= Quaternion.Euler(rotation * Time.deltaTime);
    }
}
