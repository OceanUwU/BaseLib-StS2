using BaseLib.Abstracts;
using HarmonyLib;
using MegaCrit.Sts2.Core.Models;

namespace BaseLib.Patches.Content;

public class PotionImagePathPatch {
    [HarmonyPatch(typeof(PotionModel), nameof(CustomPotionModel.PackedImagePath), MethodType.Getter)]
    private static class Image {
        static bool Prefix(PotionModel __instance, ref string __result) {
            if (__instance is CustomPotionModel model) {
                __result = model.PackedImagePath;
                return false;
            }
            return true;
        }
    }
    [HarmonyPatch(typeof(PotionModel), nameof(CustomPotionModel.PackedOutlinePath), MethodType.Getter)]
    private static class Outline {
        static bool Prefix(PotionModel __instance, ref string __result) {
            if (__instance is CustomPotionModel model) {
                __result = model.PackedOutlinePath;
                return false;
            }
            return true;
        }
    }
}