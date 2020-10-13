using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe
{
    private List<Food> _requiredFoods;

    Recipe(List<Food> foods)
	{
        _requiredFoods = foods;
	}

    public void AddedFood(Food food)
	{
		foreach (Food requiredFood in _requiredFoods)
		{
			if (requiredFood == food)
			{
				_requiredFoods.Remove(requiredFood); 
				if (_requiredFoods.Count >= 0)
				{
					FinishRecipe();
				}
			}
			
		}
	}

	private void FinishRecipe()
	{

	}
}
