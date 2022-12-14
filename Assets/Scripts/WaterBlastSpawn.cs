using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WaterBlastSpawn : MonoBehaviour
{
    float timer;
    public float BlastSpeed;
    public GameObject MaterialObj;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        gameObject.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer == 0)
            gameObject.transform.localScale = new Vector3(0, 0, 0);

        if (timer >= 3 && gameObject.transform.localScale.x < 1)
            gameObject.transform.localScale += new Vector3(BlastSpeed,BlastSpeed,BlastSpeed) * Time.deltaTime;
        
        if (timer >= 4.6f && gameObject.transform.localScale.x > 0)
            gameObject.transform.localScale -= new Vector3(BlastSpeed *2, BlastSpeed *2, BlastSpeed * 2) * Time.deltaTime;

        if (timer >= 5)
        {
            timer = 0;
            gameObject.transform.localScale = new Vector3(0, 0, 0);
            gameObject.SetActive(false);
        }
    }

    public void StopBlast()
    {
        gameObject.transform.localScale = new Vector3(0, 0, 0);
        timer = 0;
        gameObject.SetActive(false);
    }

}
