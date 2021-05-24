// Copyright Bruno Silva. All rights reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class PortfolioEditorTarget : TargetRules
{
	public PortfolioEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "Portfolio" } );
	}
}
