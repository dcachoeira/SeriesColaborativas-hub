package com.artech.seriescolaborativas.seriescolaborativas;

import android.content.Context;
import android.support.multidex.MultiDex;

import com.artech.android.ContextImpl;
import com.artech.application.MyApplication;
import com.artech.base.metadata.GenexusApplication;
import com.artech.base.services.AndroidContext;
import com.artech.base.services.IGxProcedure;
import com.artech.base.services.Services;
import com.artech.providers.EntityDataProvider;
import com.artech.controls.ads.Ads;
import com.artech.seriescolaborativas.seriescolaborativas.controls.*;
import com.genexus.Application;
import com.genexus.ClientContext;

public class MainApplication extends MyApplication
{
	@Override
	public final void onCreate()
	{
		GenexusApplication application = new GenexusApplication();
		application.setName("seriescolaborativas");
		application.setAPIUri("http://apps5.genexus.com/Id31aa0dc7e2b60f5f11ca7344c5c3dfbc/");
		application.setAppEntry("SeriesColaborativas");
		application.setMajorVersion(1);
		application.setMinorVersion(0);

		// Extensibility Point for Logging
 

		// Security
		application.setIsSecure(true);
		application.setEnableAnonymousUser(false);
		application.setClientId("bf43db0f19df404d8a1df7c0e8b099ed");
		application.setLoginObject("SDLogin");
		application.setNotAuthorizedObject("");
		application.setChangePasswordObject("");
		//application.setCompleteUserDataObject("");

		application.setAllowWebViewExecuteJavascripts(true);
		application.setAllowWebViewExecuteLocalFiles(true);

		// Dynamic Url		
		application.setUseDynamicUrl(false);
		application.setDynamicUrlAppId("SeriesColaborativas");

		// Ads
		application.setUseAds(false);
		application.setAdMobPublisherId("");
		// Notifications
		application.setUseNotification(true);
		application.setNotificationSenderId("ecc178f9-d579-4748-a822-7f690274dca6");
		application.setNotificationRegistrationHandler("NotificationsRegistrationHandler");

		// Testing
		application.setUseTestMode(false);

		MyApplication.setApp(application);


		UserControls.initializeUserControls();

		super.onCreate();

		
		AndroidContext.ApplicationContext = new ContextImpl(getApplicationContext());
    }

	@Override
	public Class<? extends com.artech.services.EntityService> getEntityServiceClass()
	{
		return AppEntityService.class;
	}

	@Override
	public EntityDataProvider getProvider()
	{
		return new AppEntityDataProvider();
	}

	@Override
	protected void attachBaseContext(Context base)
	{
		super.attachBaseContext(base);
		MultiDex.install(this);
	}

}
