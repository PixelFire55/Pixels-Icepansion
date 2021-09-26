
/*
* My sword
* Don't steal the texture
* ngl I just wanted to make a big comment here (Instead of //comment)
*/


using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Icepansion.Items
{
	public class GlacialSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Glacial Blade");
			Tooltip.SetDefault("[c/8fcbe3:Shoots a small blade of ice that follows and pierces enemies]"); //Thanks Redigit(creator of code) and AwesomePerson159(converted code to tModloader) for the Chlorophyte bullet AI!
            		DisplayName.AddTranslation(GameCulture.Chinese, "冰川剑");
			Tooltip.AddTranslation(GameCulture.Chinese, "[c/8fcbe3:发射会追踪并穿透敌人的冰刃]");
		}

		public override void SetDefaults() 
		{
			item.damage = 100;
			item.melee = true;
			item.width = 160;
			item.height = 160;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("IceBlade");
			item.shootSpeed = 12;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "OreBar", 18);
			recipe.AddIngredient(1570);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
