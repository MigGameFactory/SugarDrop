using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public Text animTargetText;
    private float animSpeed = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 프레임마다 텍스트가 좌우로 흔들리는 애니메이션
        // PingPong을 사용하여 0과 1 사이에서 반복하는 값 계산
        float animDegRange = Mathf.PingPong(Time.time * animSpeed, 1.0f) -0.5f;

        // 회전값을 z축 기준으로 변경
        animTargetText.transform.rotation = Quaternion.Euler(0, 0, animDegRange * 10f); // 10f는 흔들림 범위
    }
}
