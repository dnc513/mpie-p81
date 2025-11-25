using UnityEngine;
using System.Collections;

public class LightningController : MonoBehaviour
{
    // Inspector에서 LightningFlash Light를 할당
    public Light lightningLight;
    public float flashIntensity = 200f;
    public float flashDuration = 0.1f;
    public float minInterval = 5f;
    public float maxInterval = 15f;

    void Start()
    {
        if (lightningLight != null)
        {
            lightningLight.enabled = false;
            StartCoroutine(FlashCycle());
        }
    }

    IEnumerator FlashCycle()
    {
        while (true)
        {
            // 번개 간격만큼 대기
            float waitTime = Random.Range(minInterval, maxInterval);
            yield return new WaitForSeconds(waitTime);

            // 번개 섬광 효과
            lightningLight.enabled = true;
            lightningLight.intensity = flashIntensity;
            
            // 아주 짧은 시간 동안만 켜기
            yield return new WaitForSeconds(flashDuration);

            // 번개 끄기
            lightningLight.enabled = false;
        }
    }
}