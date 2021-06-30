using Terraria.ID;
using Terraria.ModLoader;

namespace Icepansion.Items
{
	public class OreTile : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glacium Ore");
			Tooltip.SetDefault("''Precious ore originating from ancient glaciers.''");
		}
		
		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 16;
			item.maxStack = 999;
			item.consumable = true;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 10;
			item.createTile = mod.TileType("TileTest");
			item.autoReuse = true;
			item.rare = 1;
		}
		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 20);
			recipe.AddIngredient(ItemID.ChlorophyteOre, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}