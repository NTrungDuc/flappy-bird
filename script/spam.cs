using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spam : MonoBehaviour
{
    public GameObject spamPrefab;
    public float maxTime;
    float timer;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer +=Time.deltaTime;
        if(timer > maxTime)
        {
            GameObject tmp = Instantiate(spamPrefab,new Vector3(transform.position.x,transform.position.y + Random.Range(-height,height),0),Quaternion.identity);
            Destroy(tmp, 10f);
            timer = 0;
        }
    }
}
