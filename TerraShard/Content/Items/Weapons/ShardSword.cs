using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
namespace TerraShard.Content.Items.Weapons
{
    internal class ShardSword : ModItem
    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shard Sword");
            Tooltip.SetDefault("Poeky Like The Cactus");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.DamageType = DamageClass.Melee;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.damage = 12;
            Item.useTime = 17;
            Item.useAnimation = 17;
            Item.knockBack = 2f;
            Item.autoReuse = true;

            Item.value = Item.buyPrice(silver: 10);
            Item.rare = ItemRarityID.Blue;

            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ModContent.ItemType<Shard>(), 8)
                .AddTile(TileID.Anvils)
                .Register();
        }
    }
}
