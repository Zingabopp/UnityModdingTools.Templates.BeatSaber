using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.Components;
using BeatSaberMarkupLanguage.ViewControllers;
using System;
using System.Collections.Generic;


namespace $rootnamespace$
{
	[HotReload(RelativePathToLayout = @"$safeitemrootname$.bsml")]
	[ViewDefinition("$rootnamespace$.$safeitemrootname$.bsml")]
	internal class $safeitemrootname$ : BSMLAutomaticViewController
	{
        [UIAction("#post-parse")]
        internal void PostParse()
        {
        }
    }
}
