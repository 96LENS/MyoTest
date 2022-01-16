using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���̈ړ��𐧌䂷��X�N���v�g�B���̃I�u�W�F�N�g�ɒ��ڃA�^�b�`���Ďg�p�B
/// </summary>
public class MoveButterfly : MonoBehaviour
{
    //=====================================================================================================================
    // �ϐ�
    //=====================================================================================================================
    public float moveSpeed = 1f;
    public float rotateSpeed = 1f;


    //=====================================================================================================================
    // �֐�
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
