using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody rBody;
    public float bulletForce = 500f;
    public float lifeTime = 4f;

    private IEnumerator Start()
    {
        rBody = GetComponent<Rigidbody>();
        //rBody.AddRelativeForce(transform.forward * bulletForce);
        rBody.AddForce(transform.forward * bulletForce);

        yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}