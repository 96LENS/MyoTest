using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pose = Thalmic.Myo.Pose;

/// <summary>
/// Myoの動きを検知するクラス
/// </summary>
public class MyoGestureManager : MonoBehaviour
{
    //=====================================================================================================================
    // 変数
    //=====================================================================================================================
    
    [Header("ステータス")]
    public Pose currentPose = Pose.Unknown;
    private Pose requestPose = Pose.Unknown;

    [Header("Myo")]
    public GameObject myoObject = null;
    public ThalmicMyo thalmicMyo = null;

    [Header("ButterFly")]
    public GameObject butterflyObject = null;
    public MoveButterfly moveButterFly = null;


    //=====================================================================================================================
    // 関数
    //=====================================================================================================================

    void Awake()
    {
        if (myoObject == null) Debug.LogError("myoオブジェクトが存在していません");
        if (butterflyObject == null) Debug.LogError("butterflyオブジェクトが存在していません");
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
            Debug.LogError("moveButterflyコンポーネントが見つかりませんでした");
            return;
        }

        // Poseステータスの更新
        requestPose = thalmicMyo.pose;
        if (requestPose != currentPose) currentPose = requestPose;

        switch (currentPose)
        {
            // グーのとき
            case Pose.Fist:
                break;

            // 内側に曲げたとき
            case Pose.WaveIn:
                break;

            // 外側に曲げたとき
            case Pose.WaveOut:
                break;

            // 手を広げているとき
            case Pose.FingersSpread:
                break;

            // 特に何もしていないとき
            case Pose.Rest:
                Vector3 myoCurrentGyroscope = thalmicMyo.gyroscope;

                moveButterFly.UpdatePosition();
                moveButterFly.UpdateRotation(myoCurrentGyroscope);
                break;
        }

    }
}
