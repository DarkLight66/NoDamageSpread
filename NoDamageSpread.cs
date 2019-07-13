using System;
using Terraria.ModLoader;

namespace NoDamageSpread
{
	public class NoDamageSpread : Mod
	{
		public static Configuration Config { get; internal set; }

		public override void Load() => On.Terraria.Main.DamageVar += (orig, dmg) => !Config.DisableDamageSpread ? orig(dmg) : (int)Math.Round(dmg);

		public override void Unload() => Config = null;
	}
}