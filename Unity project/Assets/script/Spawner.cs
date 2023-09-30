using UnityEngine;

class Spawner : MonoBehaviour
{
    private float Timer = 0;
    public float SpawnTime;
    public GameObject ObstaclePrefab;    // Update is called once per frame
    private void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= SpawnTime)
        {
            Instantiate(ObstaclePrefab, transform.position, Quaternion.identity);
            Timer = 0;
        }
    }
}
