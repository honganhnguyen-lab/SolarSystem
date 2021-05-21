using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLook : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    
    // Update is called once per frame
    void OnMouseDown()
    {
        LookAt.target = target;
        Camera.main.fieldOfView = Mathf.Clamp(target.transform.localScale.x*10, 1, 100);
    }
}
