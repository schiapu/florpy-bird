using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnController : MonoBehaviour
{
    [SerializeField]
    private GameObject pipe;

    [SerializeField]
    private float spawnRate = 2;

    private float timer = 0;

    [SerializeField]
    private float heightOffset = 10;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            timer = 0;
        }
    }

    private void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z), transform.rotation);
    }

}
