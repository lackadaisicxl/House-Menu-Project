using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    public GameObject item;
    public Vector3 newPosition;

    public void Spawn()
    {
                Instantiate(item, newPosition, Quaternion.identity);
        item.SetActive(true);
    }
    void Start()
    {
        // Set the spawn position using Vector3 constructor
        newPosition = new Vector3(2f, 0f, 3f); // Set spawn position to (2, 0, 3)
        item.SetActive(false);
        // Call the SpawnObject function to spawn the object at the start of the scene or at a desired interval
        Spawn();
    }

}