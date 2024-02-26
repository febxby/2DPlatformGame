using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance { get; private set; }
    private CinemachineVirtualCamera virtualCamera;
    private float shakeTimer, shakeTimerTotal, startingAmplitude;
    CinemachineBasicMultiChannelPerlin perlin;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        perlin = virtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (shakeTimer > 0)
        {
            shakeTimer -= Time.fixedDeltaTime;
            perlin.m_AmplitudeGain = Mathf.Lerp(startingAmplitude, 0, 1 - (shakeTimer / shakeTimerTotal));
        }
    }
    public void ShakeCamera(float amplitude, float time)
    {
        perlin.m_AmplitudeGain = amplitude;
        startingAmplitude = amplitude;
        shakeTimerTotal = time;
        shakeTimer = time;
    }
}
