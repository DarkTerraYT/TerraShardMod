using Terraria;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace TerraShard.Content.Items
{
    internal class Shard : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Translucent");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 100;
        }

        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;

            Item.value = Item.buyPrice(silver: 1);
            Item.maxStack = 999;
        }
    }
}
