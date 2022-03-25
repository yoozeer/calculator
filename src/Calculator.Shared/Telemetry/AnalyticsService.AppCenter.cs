#if (!__MACCATALYST__ && !__IOS__) || (__IOS__ && !NET6_0_OR_GREATER) || __ANDROID__ || __MACOS__ || NETFX_CORE
#define CAN_USE_APPCENTER
#endif

using System;
using System.Collections.Generic;
using System.Text;

#if CAN_USE_APPCENTER
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
#endif

namespace CalculatorApp.Telemetry
{
	internal static partial class AnalyticsService
	{
		static partial void InitializePartial()
		{
#if __IOS__
			var id = "adc1f082-0f58-4bc6-8eb0-b318bc89079b";
#elif __MACOS__
			var id = "2a4e2da4-ebf6-44d9-a84f-f82eaa0ba130";
#elif __ANDROID__
			var id = "c1ba47a3-9fb5-4365-af27-6eed6e0ca4bf";
#elif NETFX_CORE
			var id = "d46819e8-746b-40b8-824e-53fb666b53e8";
#endif

#if CAN_USE_APPCENTER
			AppCenter.Start(
				id,
				typeof(Analytics),
				typeof(Crashes));
#endif
		}

		static partial void TrackViewPartial(string viewName)
		{
#if CAN_USE_APPCENTER
			Analytics.TrackEvent(viewName);
#endif
		}
	}
}
