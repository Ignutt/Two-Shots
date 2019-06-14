using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    public float speed = 1;
    Vector3 v3;
    void Start()
    {
        v3 = new Vector3(0, 0, speed);
    }

    void Update()
    {
        transform.Translate(v3 * Time.deltaTime);
        Collider[] c = Physics.OverlapSphere(transform.position, v3.z * Time.deltaTime);
        if (c != null) foreach (Collider coll in c) OnBulletEnter(coll);
    }

    private void OnBulletEnter(Collider other)
    {
        GameObject.Destroy(gameObject);
        HealthPoint hp = other.GetComponent<HealthPoint>();
        if (hp)
        {
            hp.Health -= 10;
        }
        print(other.name);
    }
}
