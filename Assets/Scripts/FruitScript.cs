using UnityEngine;

public class FruitScript : MonoBehaviour
{
    // 게임 오브젝트 참조
    float randPosX;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 연산 속도(컴퓨터 성능)에 따라서 위치 값의 차이가 발생함
        // 모든 기기가 1초에 60번만 계산하여 동일한 이동 속도 값 적용
        Application.targetFrameRate = 60;


        randPosX = Random.Range(-2.5f, 2.5f);
        transform.position = new Vector3(randPosX, 5.7f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
    }
}
