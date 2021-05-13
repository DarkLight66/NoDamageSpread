using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace NoDamageSpread
{
	[Label("No Damage Spread")]
	public class Configuration : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		public static Configuration Instance;

		[Label("Disable Random Damage Spread")]
		[Tooltip("Disables the randomness applied to damage dealt to players and enemies\nDefaults to true")]
		[DefaultValue(true)]
		public bool DisableDamageSpread;

		public override void OnLoaded()
		{
			OldDisableDamageSpread = DisableDamageSpread;
		}

		private bool OldDisableDamageSpread;

		public override void OnChanged()
		{
			if (OldDisableDamageSpread != DisableDamageSpread)
			{
				Mod.Logger.Info((DisableDamageSpread ? "Disabled" : "Enabled") + " random damage spread");
				OldDisableDamageSpread = DisableDamageSpread;
			}
		}
	}
}
