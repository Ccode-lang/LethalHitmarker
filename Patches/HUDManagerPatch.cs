using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace LethalHitmarker.Patches
{
    [HarmonyPatch(typeof(HUDManager), "OnEnable")]
    internal class HUDManagerPatch
    {
        public static void Postfix()
        {
            UnityEngine.Object.Instantiate(Plugin.newUI);
        }
    }
}
