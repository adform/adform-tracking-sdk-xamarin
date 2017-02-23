using System;
using Foundation;
using ObjCRuntime;

namespace AdformTrackingBindingiOS
{
	// @interface AdformTrackingSDK : NSObject
	[BaseType(typeof(NSObject))]
	interface AdformTrackingSDK
	{
		// @property (readonly, getter = isEnabled, assign, nonatomic) BOOL enabled;
		[Export("enabled")]
		bool Enabled { [Bind("isEnabled")] get; }

		// @property (readonly, getter = isSendSimCardStateEnabled, assign, nonatomic) BOOL sendSimCardStateEnabled;
		[Export("sendSimCardStateEnabled")]
		bool SendSimCardStateEnabled { [Bind("isSendSimCardStateEnabled")] get; }

		// @property (readonly, getter = isHTTPSEnabled, assign, nonatomic) BOOL HTTPSEnabled;
		[Export("HTTPSEnabled")]
		bool HTTPSEnabled { [Bind("isHTTPSEnabled")] get; }

		// +(AdformTrackingSDK *)sharedInstance;
		[Static]
		[Export("sharedInstance")]
		AdformTrackingSDK SharedInstance { get; }

		// -(void)setEnabled:(BOOL)enabled;
		[Export("setEnabled:")]
		void SetEnabled(bool enabled);

		// -(void)setSendSimCardStateEnabled:(BOOL)enabled;
		[Export("setSendSimCardStateEnabled:")]
		void SetSendSimCardStateEnabled(bool enabled);

		// -(void)startTracking:(long)trackingPointId;
		[Export("startTracking:")]
		void StartTracking(nint trackingPointId);

		// -(void)startTrackingWithIds:(NSArray<NSNumber *> *)trackingPointIds;
		[Export("startTrackingWithIds:")]
		void StartTrackingWithIds(NSNumber[] trackingPointIds);

		// -(void)sendTrackPoint:(AFTrackPoint *)trackPoint;
		[Export("sendTrackPoint:")]
		void SendTrackPoint(AFTrackPoint trackPoint);

		// -(void)sendTrackPoints:(NSArray<AFTrackPoint *> *)trackPoints;
		[Export("sendTrackPoints:")]
		void SendTrackPoints(AFTrackPoint[] trackPoints);

		// -(void)setAppName:(NSString *)applicationName;
		[Export("setAppName:")]
		void SetAppName(string applicationName);

		// -(void)setOrder:(AFOrder *)order;
		[Export("setOrder:")]
		void SetOrder(AFOrder order);

		// -(BOOL)applicationOpenUrl:(NSURL *)url sourceApplication:(NSString *)sourceApplication;
		[Export("applicationOpenUrl:sourceApplication:")]
		bool ApplicationOpenUrl(NSUrl url, string sourceApplication);

		// -(void)setHTTPSEnabled:(BOOL)HTTPSEnabled;
		[Export("setHTTPSEnabled:")]
		void SetHTTPSEnabled(bool HTTPSEnabled);
	}

	// @interface AFTrackPoint : NSObject
	[BaseType(typeof(NSObject))]
	interface AFTrackPoint
	{
		// -(id)initTrackPoint:(long)trackingPointId;
		[Export("initTrackPoint:")]
		IntPtr Constructor(nint trackingPointId);

		// -(long)getTrackPointId;
		[Export("getTrackPointId")]
		nint TrackPointId { get; }

		// -(NSString *)getSectionName;
		[Export("getSectionName")]
		string SectionName { get; }

		// - (void)setSectionName:(NSString *)sectionName;
		[Export("setSectionName:")]
		void SetSectionName(string sectionName);

		// -(NSString *)getAppName;
		[Export("getAppName")]
		string AppName { get; }

		// -(void)setAppName:(NSString *)applicationName;
		[Export("setAppName:")]
		void SetAppName(string applicationName);

		// -(NSArray *)products;
		// -(void)setProducts:(NSArray *)products;
		[Export("products")]
		AFProduct[] Products { get; set; }

		// -(void)addProduct:(AFProduct *)product;
		[Export("addProduct:")]
		void AddProduct(AFProduct product);

		// - (AFOrder *)order;
		// - (void)setOrder:(AFOrder *)order;
		[Export("order")]
		AFOrder Order { get; set; }
	}

	// @interface AFTrackPointsBuilder : NSObject
	[BaseType (typeof(NSObject))]
	interface AFTrackPointsBuilder
	{
		// @property (nonatomic, strong) NSArray<NSNumber *> * trackPointIds;
		[Export("trackPointIds", ArgumentSemantic.Strong)]
		NSNumber[] TrackPointIds { get; set; }

		// @property (nonatomic, strong) NSString * applicationName;
		[Export("applicationName", ArgumentSemantic.Strong)]
		string ApplicationName { get; set; }

		// @property (nonatomic, strong) NSString * sectionName;
		[Export("sectionName", ArgumentSemantic.Strong)]
		string SectionName { get; set; }

		// @property (nonatomic, strong) NSArray<AFProduct *> * products;
		[Export("products", ArgumentSemantic.Strong)]
		AFProduct[] Products { get; set; }

		// @property (nonatomic, strong) AFOrder * order;
		[Export("order", ArgumentSemantic.Strong)]
		AFOrder Order { get; set; }

		// -(instancetype)initWithAppName:(NSString *)appName sectionName:(NSString *)sectionName products:(NSArray<AFProduct *> *)products order:(AFOrder *)order trackPointIds:(NSArray<NSNumber *> *)trackpointIds;
		[Export("initWithAppName:sectionName:products:order:trackPointIds:")]
		IntPtr Constructor(string appName, string sectionName, AFProduct[] products, AFOrder order, NSNumber[] trackpointIds);

		// -(NSArray<AFTrackPoint *> *)build;
		[Export("build")]
		AFTrackPoint[] Build();
	}

	// @interface AFProduct : NSObject
	[BaseType(typeof(NSObject))]
	interface AFProduct
	{
		// @property (nonatomic, strong) NSString * categoryName;
		[Export("categoryName", ArgumentSemantic.Strong)]
		string CategoryName { get; set; }

		// @property (nonatomic, strong) NSString * categoryId;
		[Export("categoryId", ArgumentSemantic.Strong)]
		string CategoryId { get; set; }

		// @property (nonatomic, strong) NSString * productName;
		[Export("productName", ArgumentSemantic.Strong)]
		string ProductName { get; set; }

		// @property (nonatomic, strong) NSString * productId;
		[Export("productId", ArgumentSemantic.Strong)]
		string ProductId { get; set; }

		// @property (assign, nonatomic) NSInteger weight;
		[Export("weight")]
		nint Weight { get; set; }

		// @property (assign, nonatomic) AFEcomerceStep step;
		[Export("step", ArgumentSemantic.Assign)]
		AFEcomerceStep Step { get; set; }

		// @property (assign, nonatomic) float productSales;
		[Export("productSales")]
		float ProductSales { get; set; }

		// @property (assign, nonatomic) NSInteger productCount;
		[Export("productCount")]
		nint ProductCount { get; set; }

		// @property (nonatomic, strong) NSString * custom;
		[Export("custom", ArgumentSemantic.Strong)]
		string Custom { get; set; }

		// -(instancetype)initWithCategoryName:(NSString *)categoryName categoryId:(NSString *)categoryId productName:(NSString *)productName productId:(NSString *)productId weight:(NSInteger)weight step:(NSInteger)step productSales:(float)productSales productCount:(NSInteger)productCount custom:(NSString *)custom;
		[Export("initWithCategoryName:categoryId:productName:productId:weight:step:productSales:productCount:custom:")]
		IntPtr Constructor(string categoryName, string categoryId, string productName, string productId, nint weight, nint step, float productSales, nint productCount, string custom);
	}

	// @interface AFOrder : NSObject
	[BaseType(typeof(NSObject))]
	interface AFOrder
	{
		// @property (nonatomic, strong) NSString * orderId;
		[Export("orderId", ArgumentSemantic.Strong)]
		string OrderId { get; set; }

		// @property (assign, nonatomic) float sale;
		[Export("sale")]
		float Sale { get; set; }

		// @property (assign, nonatomic) NSInteger basketSize;
		[Export("basketSize")]
		nint BasketSize { get; set; }

		// @property (nonatomic, strong) NSString * currency;
		[Export("currency", ArgumentSemantic.Strong)]
		string Currency { get; set; }

		// @property (nonatomic, strong) NSString * orderStatus;
		[Export("orderStatus", ArgumentSemantic.Strong)]
		string OrderStatus { get; set; }

		// @property (nonatomic, strong) NSString * firstName;
		[Export("firstName", ArgumentSemantic.Strong)]
		string FirstName { get; set; }

		// @property (nonatomic, strong) NSString * lastName;
		[Export("lastName", ArgumentSemantic.Strong)]
		string LastName { get; set; }

		// @property (nonatomic, strong) NSString * country;
		[Export("country", ArgumentSemantic.Strong)]
		string Country { get; set; }

		// @property (nonatomic, strong) NSString * address1;
		[Export("address1", ArgumentSemantic.Strong)]
		string Address1 { get; set; }

		// @property (nonatomic, strong) NSString * address2;
		[Export("address2", ArgumentSemantic.Strong)]
		string Address2 { get; set; }

		// @property (nonatomic, strong) NSString * zip;
		[Export("zip", ArgumentSemantic.Strong)]
		string Zip { get; set; }

		// @property (nonatomic, strong) NSString * email;
		[Export("email", ArgumentSemantic.Strong)]
		string Email { get; set; }

		// @property (nonatomic, strong) NSString * phone;
		[Export("phone", ArgumentSemantic.Strong)]
		string Phone { get; set; }

		// @property (nonatomic, strong) NSString * gender;
		[Export("gender", ArgumentSemantic.Strong)]
		string Gender { get; set; }

		// @property (nonatomic, strong) NSString * ageGroup;
		[Export("ageGroup", ArgumentSemantic.Strong)]
		string AgeGroup { get; set; }

		// @property (nonatomic, strong) NSMutableDictionary<NSNumber *,NSString *> * customVariables;
		[Export("customVariables", ArgumentSemantic.Strong)]
		NSMutableDictionary<NSNumber, NSString> CustomVariables { get; set; }

		// -(void)setCustomVariable:(NSString *)variable forKey:(NSInteger)key;
		[Export("setCustomVariable:forKey:")]
		void SetCustomVariable(string variable, nint key);

		// @property (nonatomic, strong) NSMutableDictionary<NSNumber *,NSString *> * systemVariables;
		[Export("systemVariables", ArgumentSemantic.Strong)]
		NSMutableDictionary<NSNumber, NSString> SystemVariables { get; set; }

		// -(void)setSystemVariable:(NSString *)variable forKey:(NSInteger)key;
		[Export("setSystemVariable:forKey:")]
		void SetSystemVariable(string variable, nint key);

		// @property (nonatomic, strong) NSMutableDictionary<NSNumber *,NSNumber *> * numericSystemVariables;
		[Export("numericSystemVariables", ArgumentSemantic.Strong)]
		NSMutableDictionary<NSNumber, NSNumber> NumericSystemVariables { get; set; }

		// -(void)setNumericSystemVariable:(NSNumber *)variable forKey:(NSInteger)key;
		[Export("setNumericSystemVariable:forKey:")]
		void SetNumericSystemVariable(NSNumber variable, nint key);
	}

}
