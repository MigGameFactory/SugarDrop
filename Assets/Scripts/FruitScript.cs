using UnityEngine;

public class FruitScript : MonoBehaviour
{
    // 게임 오브젝트 참조
    float randPosX;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
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
