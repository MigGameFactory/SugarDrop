using UnityEngine;

public class CharacterScript : MonoBehaviour

{
    // 타이틀 캐릭터 참조
    public GameObject frogCharacter;
    public GameObject pinkmanCharacter;
    public GameObject spacemanCharacter;
    public float moveSpeed = 0.01f; // 이동 속도
    private float offsetX = 1.5f; // pinkman과 frog 사이의 거리
    private int characterDirection = -1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 연산 속도(컴퓨터 성능)에 따라서 위치 값의 차이가 발생함
        // 모든 기기가 1초에 60번만 계산하여 동일한 이동 속도 값 적용
        Application.targetFrameRate = 60;


        // 기본 위치 지정
        frogCharacter.transform.position = new Vector3(8f, -3.26f);
        pinkmanCharacter.transform.position = new Vector3(frogCharacter.transform.position.x + offsetX, -3.26f);
        spacemanCharacter.transform.position = new Vector3(pinkmanCharacter.transform.position.x + offsetX, -3.26f);
        // 캐릭터 방향 바라보기
        frogCharacter.GetComponent<SpriteRenderer>().flipX = false;
        pinkmanCharacter.GetComponent<SpriteRenderer>().flipX = false;
        spacemanCharacter.GetComponent<SpriteRenderer>().flipX = false;
    }

    // Update is called once per frame
    void Update()
    {
        // 기본 이동
        frogCharacter.transform.position += Vector3.left * moveSpeed * characterDirection;
        // pinkmanCharacter가 frogCharacter를 따라가도록 설정
        pinkmanCharacter.transform.position = new Vector3(frogCharacter.transform.position.x + offsetX, pinkmanCharacter.transform.position.y);
        spacemanCharacter.transform.position = new Vector3(pinkmanCharacter.transform.position.x + offsetX, spacemanCharacter.transform.position.y);

        // 방향 전환
        if (frogCharacter.transform.position.x > 8f || frogCharacter.transform.position.x < -8f)
        {
            // 캐릭터 반대편 바라보기
            frogCharacter.GetComponent<SpriteRenderer>().flipX = !frogCharacter.GetComponent<SpriteRenderer>().flipX;
            pinkmanCharacter.GetComponent<SpriteRenderer>().flipX = !pinkmanCharacter.GetComponent<SpriteRenderer>().flipX;
            spacemanCharacter.GetComponent<SpriteRenderer>().flipX = !spacemanCharacter.GetComponent<SpriteRenderer>().flipX;

            // frogCharacter가 반대쪽으로 이동
            characterDirection *= -1;
            offsetX *= -1;

        }

    }
}
