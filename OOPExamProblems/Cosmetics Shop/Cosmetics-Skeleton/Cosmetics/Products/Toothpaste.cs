namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IToothpaste
    {
        private const int MinIngredientNameLength = 4;
        private const int MaxIngredientNameLength = 12;

        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ValidateIngredients(ingredients);
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get
            {
                return string.Join(", ", this.ingredients);
            }
        }

        public override string Print()
        {
            StringBuilder sb = new StringBuilder(base.Print());

            sb.AppendFormat("  * Ingredients: {0}", this.Ingredients);

            return sb.ToString();
        }

        private void ValidateIngredients(IList<string> ingredientsInputList)
        {
            foreach (var ingredient in ingredientsInputList)
            {
                Validator.CheckIfStringIsNullOrEmpty(ingredient, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Ingredient"));
                Validator.CheckIfStringLengthIsValid(ingredient, MaxIngredientNameLength, MinIngredientNameLength, string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", MinIngredientNameLength, MaxIngredientNameLength));
            }
        }

    }
}