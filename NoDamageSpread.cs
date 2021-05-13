using System;
using Terraria.ModLoader;

namespace NoDamageSpread
{
	public class NoDamageSpread : Mod
	{
		public override void Load()	{
			On.Terraria.Main.DamageVar += (orig, dmg, luck) => !Configuration.Instance.DisableDamageSpread ? orig(dmg, luck) : (int)Math.Round(dmg);
		}
	}
}