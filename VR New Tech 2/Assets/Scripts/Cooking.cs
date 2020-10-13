using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking : MonoBehaviour
{
	private void OnTriggerEnter(Collider collider)
	{
		ICookable food = collider.gameObject.GetComponent(typeof(ICookable)) as ICookable;

		Cook(food);
	}

    private IEnumerator Cook(ICookable food)
	{
		Debug.Log("raw");
		yield return new WaitForSeconds(food.CookTime / 4);
		Debug.Log("not so raw");
		yield return new WaitForSeconds(food.CookTime / 4);
		Debug.Log("getting done");
		yield return new WaitForSeconds(food.CookTime / 4);
		Debug.Log("pretty close");
		yield return new WaitForSeconds(food.CookTime / 4);
		Debug.Log("PERFECT");
		food.SetIsCooked(true);
		yield return new WaitForSeconds(food.CookTime / 4);
		Debug.Log("Burnt...");
	}
}
