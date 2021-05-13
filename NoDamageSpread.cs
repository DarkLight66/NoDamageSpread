using System;
using Terraria.ModLoader;

namespace NoDamageSpread
{
	public class NoDamageSpread : Mod
	{
		public override void Load() => On.Terraria.Main.DamageVar += (orig, dmg) => !Configuration.Instance.DisableDamageSpread ? orig(dmg) : (int)Math.Round(dmg);
	}
}