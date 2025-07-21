using UnityEngine;
using Verse;

namespace TrulyInspiredTaming;

internal class BoostSettings : ModSettings
{
    public enum BoostType : byte
    {
        Unlimited = 0,
        Percentage = 1,
        Levels = 2
    }

    public static BoostType Boost = BoostType.Unlimited;
    public static float BoostPercentage = 0.2f;
    public static float BoostLevels = 4f;

    public void DoWindowContents(Rect canvas)
    {
        var listingStandard = new Listing_Standard
        {
            ColumnWidth = 375
        };
        listingStandard.Begin(canvas);

        Text.Font = GameFont.Medium;
        listingStandard.Label("TIT_TamingSkillBoostType".Translate());
        Text.Font = GameFont.Small;
        listingStandard.Gap();
        listingStandard.Label("TIT_SettingsExplanation".Translate());
        listingStandard.GapLine();
        listingStandard.Label(string.Empty);
        if (listingStandard.RadioButton("TIT_TameAnyAnimal".Translate(), Boost == BoostType.Unlimited))
        {
            Boost = BoostType.Unlimited;
        }

        if (listingStandard.RadioButton("TIT_BoostByPercentage".Translate(), Boost == BoostType.Percentage))
        {
            Boost = BoostType.Percentage;
        }

        if (Boost == BoostType.Percentage)
        {
            BoostPercentage =
                listingStandard.SliderLabeled($"    +{BoostPercentage.ToStringPercent()}", BoostPercentage, 0, 1);
        }

        if (listingStandard.RadioButton("TIT_BoostByLevels".Translate(), Boost == BoostType.Levels))
        {
            Boost = BoostType.Levels;
        }

        if (Boost == BoostType.Levels)
        {
            BoostLevels = listingStandard.SliderLabeled($"    +{BoostLevels}", BoostLevels, 0, 20);
        }

        if (TrulyInspiredTaming.currentVersion != null)
        {
            listingStandard.Gap();
            GUI.contentColor = Color.gray;
            listingStandard.Label("TIT_CurrentModVersion".Translate(TrulyInspiredTaming.currentVersion));
            GUI.contentColor = Color.white;
        }

        listingStandard.End();
    }

    public override void ExposeData()
    {
        base.ExposeData();
        Scribe_Values.Look(ref Boost, "Boost", BoostType.Unlimited, true);
        Scribe_Values.Look(ref BoostPercentage, "BoostPercentage", 0.2f, true);
        Scribe_Values.Look(ref BoostLevels, "BoostLevels", 4f, true);
    }
}