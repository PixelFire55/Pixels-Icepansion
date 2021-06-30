	using Terraria;
	using Terraria.ModLoader;
	using Terraria.ID;
	using Microsoft.Xna.Framework;
	
	namespace Icepansion.Items.Tiles
	{
		public class TileTest : ModTile
		{
			public override void SetDefaults()
			{
				Main.tileSolid[Type] = true;
				
				drop = mod.ItemType("OreTile");
				dustType = DustID.Platinum;
				
				ModTranslation name = CreateMapEntryName();
				name.SetDefault("Glacium Ore");
				
				AddMapEntry(new Color(32, 116, 144), name);
				
				minPick = 200;
			}
			
			
			public override void NumDust(int i, int j, bool fail, ref int num)
			{
				num = fail ? 1 : 3;
			}
		}
	}