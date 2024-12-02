using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public GameObject[] prefabs;

    List<GameObject>[] pools;

    private void Awake()
    {
        pools = new List<GameObject>[prefabs.Length]; // 풀과 프리팹의 길이 동일하게

        for (int index = 0; index < pools.Length; index++) // 배열 안에 있는 각각의 리스트들 초기화
        {
            pools[index] = new List<GameObject>();
        }
    }

    public GameObject Get(int index)
    {
        GameObject select = null;

        foreach (GameObject item in pools[index]) // 선택한 풀의 놀고있는(비활성화된) 오브젝트 접근
        {
            if (!item.activeSelf) // 발견하면?
            {
                // select 변수에 할당
                select = item;
                select.SetActive(true);
                break;
            }
        }

        if (!select) // 못찾았다면?
        {
            // 새롭게 생성하고 select 변수에 할당
            select = Instantiate(prefabs[index], transform);
            pools[index].Add(select);
        }

        return select;
    }
}
