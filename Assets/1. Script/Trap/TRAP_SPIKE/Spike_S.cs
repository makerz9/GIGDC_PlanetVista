using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike_S : MonoBehaviour
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
            yield return new WaitForSeconds(2); //방향이 바뀌는
            gameObject.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            yield return new WaitForSeconds(1); //방향이동 딜레이
            gameObject.transform.Translate(Vector3.forward * Time.deltaTime * 530);
            print("IsMoving");
        }
    }
}
