package com.artech.seriescolaborativas.sdlogin;

import com.artech.providers.EntityDataProvider;

public class AppEntityDataProvider extends EntityDataProvider
{
	public AppEntityDataProvider()
	{
		EntityDataProvider.AUTHORITY = "com.artech.seriescolaborativas.sdlogin.appentityprovider";
		EntityDataProvider.URI_MATCHER = buildUriMatcher();
	}
}
