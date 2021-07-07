using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Galaxy.Items.MetalIngot {

    // 保证类名跟文件名一致
    public class PureIronIngot : ModItem {

        // 设置物品名字，描述
        public override void SetStaticDefaults() {

            // 物品名字
            DisplayName.SetDefault("Pure iron ingot");
            // 物品中文名字
            DisplayName.AddTranslation(GameCulture.Chinese, "纯铁锭");

            // 物品的描述
            Tooltip.SetDefault("It is purified from iron ingot");
            // 物品的中文描述
            Tooltip.AddTranslation(GameCulture.Chinese, "由铁锭提纯而来" );
        }

        public override void SetDefaults() {
            
            //最大堆叠
            item.maxStack = 99;

            // 使用方式，这个值决定了武器使用时到底是按什么样的动画播放
            // 1 挥动
            // 2 喝
            // 3 刺
            // 4 举起
            // 5 手持
            item.useStyle = 1;
            
            // 攻击速度和攻击动画持续时间
            // 这个数值越低越快，因为TR游戏速度每秒是60帧，这里的20就是
            // 20.0 / 60.0 = 0.333 秒挥动一次！也就是一秒三次
            // 一般来说我们要把这两个值设成一样，但也有例外的时候，我们以后会讲
            item.useTime = 20;
            item.useAnimation = 20;

            // 物品的价格 X白金 X金 X银 X铜
            item.value = Item.sellPrice(0, 0, 4, 0);

            // 物品的稀有度，由-1到13越来越高
            item.rare = 1;

            // 自动攻击， true可以, false不行
            item.autoReuse = false;
        }
        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            // 合成材料，材料的数量
            recipe.AddIngredient(ItemID.IronBar, 2);
            // 工作站
            recipe.AddTile(TileID. Furnaces);
            // 合成物的数量
            recipe.SetResult(this);
            // 把这个合成表装进tr的系统里
            recipe.AddRecipe();
        }
    }
}
