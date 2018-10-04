package com.artech.seriescolaborativas.sdlogin;

import com.artech.android.ContextImpl;
import com.artech.application.MyApplication;
import com.artech.base.metadata.GenexusApplication;
import com.artech.base.services.AndroidContext;
import com.artech.base.services.IGxProcedure;
import com.artech.base.services.Services;
import com.artech.providers.EntityDataProvider;
import com.artech.controls.ads.Ads;
import com.artech.seriescolaborativas.sdlogin.controls.*;
import com.genexus.Application;
import com.genexus.ClientContext;

public class MainApplication extends MyApplication
{
	@Override
	public final void onCreate()
	{
		GenexusApplication application = new GenexusApplication();
		application.setName("seriescolaborativas");
		application.setAPIUri("http://10.0.2.2/SeriesColaborativas/");
		application.setAppEntry("SDLogin");
		application.setMajorVersion(1);
		application.setMinorVersion(0);

		// Extensibility Point for Logging
 

		// Security
		application.setIsSecure(true);
		application.setEnableAnonymousUser(false);
		application.setClientId("8e46013f04684f2d973b3999059120a1");
		application.setLoginObject("");
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
		application.setUseNotification(false);
		application.setNotificationSenderId("");
		application.setNotificationRegistrationHandler("(none)");

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

}
