using DataAccessLayer.Contracts;
using DomainModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Services
{
    public class FoodManagerCache
    {
        private readonly IIngredientsRepository _ingredientsRepository;
        private readonly IRecipesRepository _recipesRepository;
        private readonly IRecipeIngredientsRepository _recipeIngredientsRepository;

        private List<Ingredient> _ingredients;
        private List<Recipe> _recipes;
        private List<RecipeIngredient> _recipeIngredients;

        public FoodManagerCache(IIngredientsRepository ingredientsRepository, IRecipesRepository recipesRepository, IRecipeIngredientsRepository recipeIngredientsRepository)
        {
            _ingredientsRepository = ingredientsRepository;
            _recipesRepository = recipesRepository;
            _recipeIngredientsRepository = recipeIngredientsRepository;
        }

        public async Task RefreshData()
        {
            _ingredients = await _ingredientsRepository.GetIngredients();
            _recipeIngredients = await _recipeIngredientsRepository.GetAllRecipeIngredients();
            _recipes = await _recipesRepository.GetAllRecipes();
        }

    }
}
