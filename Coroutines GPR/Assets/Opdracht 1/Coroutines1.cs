using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Fade"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fade()
    {
        Debug.Log("Coroutine update");
        yield return new WaitForSeconds(.5f);
        Debug.Log("Coroutine update 2");
        yield return new WaitForSeconds(.5f);
        Debug.Log("Coroutine update 3");
        yield return new WaitForSeconds(.5f);
    }
}
