// Copyright (c) Sam Bloomberg

using UnrealBuildTool;

public class RichTextDialogueBox : ModuleRules
{
	public RichTextDialogueBox(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new[] { "Core", "CoreUObject", "Engine", "UMG", "Slate", "SlateCore" });
	}
}
