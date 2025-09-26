// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Untaint : ModuleRules
{
	public Untaint(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"Untaint",
			"Untaint/Variant_Platforming",
			"Untaint/Variant_Platforming/Animation",
			"Untaint/Variant_Combat",
			"Untaint/Variant_Combat/AI",
			"Untaint/Variant_Combat/Animation",
			"Untaint/Variant_Combat/Gameplay",
			"Untaint/Variant_Combat/Interfaces",
			"Untaint/Variant_Combat/UI",
			"Untaint/Variant_SideScrolling",
			"Untaint/Variant_SideScrolling/AI",
			"Untaint/Variant_SideScrolling/Gameplay",
			"Untaint/Variant_SideScrolling/Interfaces",
			"Untaint/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
