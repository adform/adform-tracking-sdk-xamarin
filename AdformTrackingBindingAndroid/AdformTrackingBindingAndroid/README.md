# Getting Started

## 1. Integration

1. Download the latest version of [Adform Tracking Xamarin SDK]().
2. Add Adform Tracking Android biddings to your solution. To do so choose Add -> Add Existing Project.., select AdformTrackingBiddingAndroid and hit Open. After this, the Adform Tracking SDK biddings will be added to your solution as a submodule.
3. Next, add a reference to Adform Tracking SDK biddings in you application project.
4. To allow the tracking SDK to use the Google Advertising ID, you must integrate Google Play Services. If you haven't done this yet, choose to `Add Packages` by your `Packages` folder in Android app project. Search for Xamarin Google Play Services - Analytics and add them to your app.
5. In Properties folder, open the `AndroidManifest.xml` of your Android app project. Add the `INTERNET` and `ACCESS_NETWORK_STATE` permissions if it's not already there.

## 2. Basic Adform Tracking SDK implementation

To start tracking, you need to run `startTracking(context, trackingId)` method. Note that Tracking_ID should be replaced with your tracking id. A good place to put it is Activity/Fragment onCreate() method. 

	AdformTrackingSdk.StartTracking(this, Tracking_ID);
	

Also, AdformTrackingSdk needs methods that would indicate of application activity, such as onResume and onPause. 

	protected override void OnResume(){
		base.OnResume ();
		AdformTrackingSdk.OnResume(this);
	}
	
	protected override void OnPause(){
		base.OnPause ();
		AdformTrackingSdk.OnPause();
	}

Optionally you can set custom application name before calling startTracking:

	AdformTrackingSdk.SetAppName("Custom app name");
	AdformTrackingSdk.StartTracking(this, Tracking_ID);
	
## Sending custom app events

To create an event, first you need to create a TrackPoint with Tracking_ID. Note that startTracking should occur before event sending.

	TrackPoint trackPoint = new TrackPoint(Tracking_ID);
	
Also some advanced integrations are available, like custom parameter or using custom application name setting.

* Setting custom tracking point name:

		trackPoint.setSectionName("Tracking point name");


* Setting custom application name:

    	trackPoint.SetAppName("Custom application name");


To send prepared track point, just use sendTrackPoint.

	AdformTrackingSdk.SendTrackPoint(trackPoint);


Also it is posible to send additional product variables information with tracking points. To do so you need to create 'ProductItem' object and set your product values. Then add that object to the trackpoint.

	ProductItem productItem = new ProductItem();
	    productItem.ProductId = "Product ID";
	    productItem.ProductName = "Product name";
	    productItem.CategoryId = "Category ID";
	    productItem.CategoryName = "Category name";
	    productItem.ProductCount = "Product count";
	    productItem.ProductSales = "Product sales";
	    productItem.Weight = "Weight";
	    productItem.Step = "Step";
	    productItem.Custom = "Custom information";
	
	TrackPoint trackPoint = new TrackPoint(Tracking_ID);
	trackPoint.AddProductItem(productItem);
	
To add order to the trackpoint, create its object and set values. Then set that object to the trackpoint.
	
	Order order = new Order ();
	order.FirstName = "John";
	order.LastName = "Smith";
	
 	trackPoint.setOrder(order);
	
## Custom Adform Tracking SDK implementations

### Enable/Disable tracking

You can enable/disable tracking by calling setEnabled(boolean) method.

	AdformTrackingSdk.SetEnabled(true);

### Enable/Disable HTTPS

You can enable/disable HTTPS protocol by calling setHttpsEnabled(boolean) method. By default HTTPS is enabled.

	AdformTrackingSdk.SetHttpsEnabled(true);

### Enable/Disable SIM card state tracking

You can enable/disable tracking by calling setSendSimCardStateEnabled(boolean) method. By default SIM card state tracking is disabled.

	AdformTrackingSdk.SetSendSimCardStateEnabled(true);
