using UnityEngine;
using System.Collections;

public class Animals : MonoBehaviour
{

    public GameObject AnimalPrefab;
    public Sprite[] AnimalSprites;

    void Start()
    {
        StartCoroutine(DropAnimal(5));
    }

    IEnumerator DropAnimal(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Vector2 pos = new Vector2(Random.Range(-1.0f, 1.0f), 7f);
            GameObject ball = Instantiate(AnimalPrefab, pos, Quaternion.AngleAxis(Random.Range(-40, 40), Vector3.forward)) as GameObject;
            int spriteId = Random.Range(0, 5);
            ball.name = "Animal" + spriteId;
            SpriteRenderer spriteObj = ball.GetComponent<SpriteRenderer>();
            spriteObj.sprite = AnimalSprites[spriteId];
            yield return new WaitForSeconds(2);
        }
    }
}