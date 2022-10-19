using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _BoomArrow : MonoBehaviour
{
    public int damage = 3;
    private float currentTime;

    void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > 5f)
        {
            Boom();
            Destroy(gameObject);
        }
    }

    void Boom()
    {
        Collider[] hitCol =Physics.OverlapSphere(transform.position, 5f);
        foreach(Collider col in hitCol)
        {
            if(col.transform.tag == "Enemy")
            {
                EnemyAI enemy = col.transform.GetComponent<EnemyAI>();
                enemy.Damage(damage);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            Boom();
        }
    }
}
