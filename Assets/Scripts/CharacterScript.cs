using UnityEngine;

public class CharacterScript : MonoBehaviour

{
    // 타이틀 캐릭터 참조
    public GameObject frogCharacter;
    public GameObject pinkmanCharacter;
    public float moveSpeed = 0.01f; // 이동 속도
    private float offsetX = 1.5f; // pinkman과 frog 사이의 거리

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        frogCharacter.transform.position = new Vector3(10f, -3.26f);
        pinkmanCharacter.transform.position = new Vector3(frogCharacter.transform.position.x + offsetX, -3.26f);
    }

    // Update is called once per frame
    void Update()
    {
        // frogCharacter가 왼쪽으로 이동
        frogCharacter.transform.position += Vector3.left * moveSpeed;

        // pinkmanCharacter가 frogCharacter를 따라가도록 설정
        pinkmanCharacter.transform.position = new Vector3(frogCharacter.transform.position.x + offsetX, pinkmanCharacter.transform.position.y);
    }
}
