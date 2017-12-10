using UnityEngine;
using System.Collections;

public class Animals : MonoBehaviour
{

    public GameObject[] animalPrefabs;

    void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            DropAnimal();
        }
    }

    void DropAnimal()
    {
        int prefabId = Random.Range(0, 11);
        Camera gameCamera = Camera.main;
        Vector2 pos = Input.mousePosition;
        Vector3 worldPos = gameCamera.ScreenToWorldPoint(pos);
        worldPos.z = 0f;
        GameObject animalPrefab = animalPrefabs[prefabId];
        GameObject animal = Instantiate(animalPrefab, worldPos, Quaternion.AngleAxis(Random.Range(-40, 40), Vector3.forward)) as GameObject;
        animal.name = "Animal" + prefabId;
    }
}