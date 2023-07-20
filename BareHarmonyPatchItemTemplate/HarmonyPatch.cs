using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HarmonyLib;

namespace $rootnamespace$
{
    [HarmonyPatch(typeof(ClassToPatch), "MethodToPatch")]
    public class $safeitemrootname$
    {
        static void Prefix(ClassToPatch __instance)
        {
        }
    }
}