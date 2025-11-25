using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    private Light myLight;
    private float initialIntensity;
    // Perlin Noise를 위한 임의의 시작 위치
    private float randomOffset; 

    public float minIntensity = 1f;
    public float maxIntensity = 3f;
    public float flickerSpeed = 0.5f;

    void Start()
    {
        myLight = GetComponent<Light>();
        initialIntensity = myLight.intensity;
        // Perlin Noise 샘플링을 위한 랜덤 오프셋 설정
        randomOffset = Random.Range(0f, 1000f); 
    }

    void Update()
    {
        // 시간과 랜덤 오프셋을 기반으로 Perlin Noise 값 생성 (0.0 ~ 1.0 사이의 부드러운 임의 값)
        float noise = Mathf.PerlinNoise(Time.time * flickerSpeed + randomOffset, 0f);

        // Perlin Noise 값을 이용하여 최소/최대 강도 사이를 보간
        myLight.intensity = Mathf.Lerp(minIntensity, maxIntensity, noise);
    }
}