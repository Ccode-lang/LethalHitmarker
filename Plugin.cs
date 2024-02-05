using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace LethalHitmarker
{
    [BepInPlugin(MyGuid, PluginName, VersionString)]
    public class Plugin : BaseUnityPlugin
    {
        private const string MyGuid = "Ccode.Rectile";
        private const string PluginName = "LethalHitmarker";
        private const string VersionString = "1.0";

        private static readonly Harmony Harmony = new Harmony(MyGuid);

        public static ManualLogSource Log;

        public static GameObject newUI;
        public void Awake()
        {
            string location = ((BaseUnityPlugin)this).Info.Location;
            string text = "LethalHitmarker.dll";
            string text2 = location.TrimEnd(text.ToCharArray());
            string text3 = text2 + "rectile";
            AssetBundle val = AssetBundle.LoadFromFile(text3);
            newUI = val.LoadAsset<GameObject>("Rectile Container");
            Harmony.PatchAll();
            Logger.LogInfo(PluginName + " " + VersionString + " " + "loaded.");
            Log = Logger;
        }
    }
}
