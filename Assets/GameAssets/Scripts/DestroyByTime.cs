using UnityEngine;
using System.Collections;

public class DestroyByTime : MonoBehaviour
{
	public float lifetime;

	private void OnEnable()
	{
		StartCoroutine(ReturnToPool());
	}

	IEnumerator ReturnToPool()
	{
		yield return new WaitForSeconds(lifetime);
		PoolManager.Instance.ReturnToPool(gameObject);
	}
		
}
