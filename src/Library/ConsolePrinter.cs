using System;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter : IPrinter
    {

        public void PrintRecipe(IRecipeContent iRecipe)
        {
            Console.WriteLine(iRecipe.GetTextToPrint());
        }

        /*
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }*/
    }
}