using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pose = Thalmic.Myo.Pose;

/// <summary>
/// Myo�̓��������m����N���X
/// </summary>
public class MyoGestureManager : MonoBehaviour
{
    //=====================================================================================================================
    // �ϐ�
    //=====================================================================================================================
    
    [Header("�X�e�[�^�X")]
    public Pose currentPose = Pose.Unknown;
    private Pose requestPose = Pose.Unknown;

    [Header("Myo")]
    public GameObject myoObject = null;
    public ThalmicMyo thalmicMyo = null;

    [Header("ButterFly")]
    public GameObject butterflyObject = null;
    public MoveButterfly moveButterFly = null;


    //=====================================================================================================================
    // �֐�
    //=====================================================================================================================

    void Awake()
    {
        if (myoObject == null) Debug.LogError("myo�I�u�W�F�N�g�����݂��Ă��܂���");
        if (butterflyObject == null) Debug.LogError("butterfly�I�u�W�F�N�g�����݂��Ă��܂���");
    }

    void Start()
    {
        if (myoObject != null) thalmicMyo = myoObject.GetComponentInChildren<ThalmicMyo>();
        if (butterflyObject != null) moveButterFly = butterflyObject.GetComponent<MoveButterfly>();
    }

    void Update()
    {
        if(moveButterFly == null)
        {
            Debug.LogError("moveButterfly�R���|�[�l���g��������܂���ł���");
            return;
        }

        // Pose�X�e�[�^�X�̍X�V
        requestPose = thalmicMyo.pose;
        if (requestPose != currentPose) currentPose = requestPose;

        switch (currentPose)
        {
            // �O�[�̂Ƃ�
            case Pose.Fist:
                break;

            // �����ɋȂ����Ƃ�
            case Pose.WaveIn:
                break;

            // �O���ɋȂ����Ƃ�
            case Pose.WaveOut:
                break;

            // ����L���Ă���Ƃ�
            case Pose.FingersSpread:
                break;

            // ���ɉ������Ă��Ȃ��Ƃ�
            case Pose.Rest:
                Vector3 myoCurrentGyroscope = thalmicMyo.gyroscope;

                moveButterFly.UpdatePosition();
                moveButterFly.UpdateRotation(myoCurrentGyroscope);
                break;
        }

    }
}
