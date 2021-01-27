using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowcamera : MonoBehaviour
{
    public Camera cam;

    private void Update()
    {
        cam.orthographicSize -= Time.deltaTime*0.5f;
        if (cam.orthographicSize==0)
        {
            cam.orthographicSize = 0;
            GameManager.Instance.LoadScene();
        }
    }
}
