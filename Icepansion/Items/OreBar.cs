using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Icepansion.Items
{
	public class OreBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Refined Glacium");
			Tooltip.SetDefault("''Precious metal forged from ancient glaciers.''");
			DisplayName.AddTranslation(GameCulture.Chinese, "冰川锭");
			Tooltip.AddTranslation(GameCulture.Chinese, "'由远古寒冰冶炼而成的贵重金属.'");
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
