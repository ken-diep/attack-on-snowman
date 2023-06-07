using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class RevisedProjectile : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-0.6f, 0.5f, 0.0f);

    [SerializeField] private float timeoutDelay = 3f;

    private IObjectPool<RevisedProjectile> objectPool;

    public IObjectPool<RevisedProjectile> ObjectPool {set => objectPool = value;}
    // Start is called before the first frame update
    public void Deactivate()
    {
        StartCoroutine(DeactivateRoutine(timeoutDelay));
    }

    IEnumerator DeactivateRoutine(float delay)
    {
        yield return new WaitForSeconds(delay);

        Rigidbody rBody = GetComponent<Rigidbody>();
        rBody.velocity = new Vector3(0f, 0f, 0f);
        rBody.angularVelocity = new Vector3(0f, 0f, 0f);

        objectPool.Release(this);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = GameObject.Find("Catapult").transform.position + offset;
    }
}
