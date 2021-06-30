using Terraria.ID;
using Terraria.ModLoader;

namespace Icepansion.Items
{
	public class OreBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Refined Glacium");
			Tooltip.SetDefault("''Precious metal forged from ancient glaciers.''");
		}
		
		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.rare = 1;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "OreTile", 5);
			recipe.AddTile(133);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}