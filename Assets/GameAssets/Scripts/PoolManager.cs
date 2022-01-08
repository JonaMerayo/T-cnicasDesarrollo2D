using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public static PoolManager Instance
    {
        get; private set;
    }

    public GameObject objToInstantiate;
    public int initialAmount = 1;

    private List<GameObject> pool = new List<GameObject>();

    public void Awake()
    {
        Instance = this;
        FillPool();
    }

    private void FillPool()
    {
        for (int i = 0; i < initialAmount; i++)
        {
            GameObject obj = Instantiate(objToInstantiate);
            obj.SetActive(false);

            pool.Add(obj);
        }
                
    }

    /*
        To instantiate (after adding it to any Game Object): PoolManager.Instance.GetNext().transform.position = anypositionchosen.position;
    */
    public GameObject GetNext()
    {
        GameObject retgo;

        if (pool.Count > 0)
        {
            retgo = pool[pool.Count - 1];
            pool.RemoveAt(pool.Count - 1);
        }
        else
        {
            retgo = Instantiate(objToInstantiate);
        }

        retgo.SetActive(true);

        return retgo;
    }

    /*
        To return, in the instance. For example to return 5 seconds after appear.
        
            private void OnEnable()
            {
                StartCoroutine(ReturnToPool());
            }

            IEnumerator ReturnToPool()
            {
                yield return new WaitForSeconds(5);
                PoolManager.Instance.ReturnToPool(gameObject);
            }

    */
    public void ReturnToPool(GameObject obj)
    {
        obj.SetActive(false);
        pool.Add(obj);

    }

    
}
