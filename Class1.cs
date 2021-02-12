using System;
using System.Threading.Tasks;
using CitizenFX.Core;

namespace Colload
{
    public class Class1 : BaseScript
    {

        public Class1()
        {
            Tick += OnTick;
            EventHandlers["playerSpawned"] += new Action<Vector3>(playerSpawned);
        }

        private async Task OnTick()
        {
            await Delay(60000);
        }

        private void playerSpawned([FromSource] Vector3 spawn)
        {
            Game.PlayerPed.Weapons.RemoveAll();
            Game.PlayerPed.Weapons.Give(WeaponHash.AssaultRifleMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.BullpupRifleMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.SMGMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.SpecialCarbineMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.CombatMGMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.HeavySniperMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.MarksmanRifleMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.PumpShotgunMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.RevolverMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.CarbineRifleMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.PistolMk2, 100, false, true);
            Game.PlayerPed.Weapons.Give(WeaponHash.SNSPistolMk2, 100, false, true);
            


            TriggerEvent("chat:addMessage", new
            {
                color = new[] {255,0,0},
                multiline = true,
                args = new[] { "[LOADOUT]", "^3You got the weapons chief" }
            });
        }

    }
}

