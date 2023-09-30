using System.Collections;
using UnityEngine;

public class Game : MonoBehaviour
{
    static float timer = 0f;    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timer = timer + Time.deltaTime;

        print(timer);

        if(timer >= 2f && timer <= 2.4f)
        {
            GameObject.Find("UFO").transform.position = new Vector3(-3, -4, 0);
        }
    }
}
