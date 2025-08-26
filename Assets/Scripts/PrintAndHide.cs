using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i;
    // Start is called before the first frame update
    public Renderer rend;
    private int blueDisableFrame;
    void Start()
    {
        i = 3;
        if (CompareTag("Blue"))
        {
            blueDisableFrame = Random.Range(150, 251);
        }
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        if (CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        // If BluePrefab hits its random number → disable Renderer
        if (CompareTag("Blue") && i == blueDisableFrame)
        {
            if (rend != null)
            {
                rend.enabled = false;
            }
        }
    }
}
