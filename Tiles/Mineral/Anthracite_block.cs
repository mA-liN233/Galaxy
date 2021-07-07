using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Galaxy.Tiles.Mineral
{
	public class Anthracite_block : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			//Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 410; // 是否被金属探测器探测到
			//Main.tileShine2[Type] = true; // Modifies the draw color slightly.Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			//Main.tileShine[Type] = 975; // 物块上的粒子效果
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;//是否阻挡光线

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("煤炭块");
			AddMapEntry(new Color(30, 30, 30), name);//在地图上显示成什么颜色，name指的是物块的名字，在name.SetDefault

			drop = ModContent.ItemType<Items.Mineral.Anthracite>();//破坏物块后的掉落物
			soundType = SoundID.Tink;
			soundStyle = 1;
			//mineResist = 4f;
			//minPick = 200;
		}
	}
}