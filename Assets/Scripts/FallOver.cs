using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit my head");
        this.transform.parent.parent.parent.gameObject.GetComponent<Health>().Damage(100);
    }
}
