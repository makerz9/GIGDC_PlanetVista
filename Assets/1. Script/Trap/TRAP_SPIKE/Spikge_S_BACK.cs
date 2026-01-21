using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_S_BACK : MonoBehaviour
{



    private void Start()
    {
        //_enemyStats = gameObject.GetComponent<EnemyStats>();
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (true)
        {
            yield return new WaitForSeconds(6);
            gameObject.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            yield return new WaitForSeconds(1);
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 50);
            print("IsMoving");
        }
    }
}
