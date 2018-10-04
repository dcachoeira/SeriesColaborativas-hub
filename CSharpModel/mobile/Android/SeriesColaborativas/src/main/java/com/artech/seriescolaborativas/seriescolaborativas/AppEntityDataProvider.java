package com.artech.seriescolaborativas.seriescolaborativas;

import com.artech.providers.EntityDataProvider;

public class AppEntityDataProvider extends EntityDataProvider
{
	public AppEntityDataProvider()
	{
		EntityDataProvider.AUTHORITY = "com.artech.seriescolaborativas.seriescolaborativas.appentityprovider";
		EntityDataProvider.URI_MATCHER = buildUriMatcher();
	}
}
