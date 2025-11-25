using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    // Inspector에서 Spotlight를 드래그하여 할당할 변수
    public Light flashlight; 

    // 게임 시작 시 호출
    void Start()
    {
        // 손전등이 할당되지 않았다면 경고 출력
        if (flashlight == null)
        {
            Debug.LogError("Flashlight Light component is not assigned!");
            return;
        }
        // 시작 시 손전등을 꺼둡니다. (원하는 경우 true로 시작 가능)
        flashlight.enabled = false;
    }

    // 매 프레임마다 호출
    void Update()
    {
        // 'F' 키를 눌렀는지 확인
        if (Input.GetKeyDown(KeyCode.F))
        {
            // 손전등의 활성화 상태를 토글합니다. (켜져 있으면 끄고, 꺼져 있으면 켭니다.)
            flashlight.enabled = !flashlight.enabled;
        }
    }
}