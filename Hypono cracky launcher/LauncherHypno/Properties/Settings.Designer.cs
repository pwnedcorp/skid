﻿using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace LauncherHypno.Properties
{
	// Token: 0x02000005 RID: 5
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000025E3 File Offset: 0x000007E3
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000007 RID: 7
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
