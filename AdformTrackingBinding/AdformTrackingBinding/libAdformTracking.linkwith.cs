using ObjCRuntime;

[assembly: LinkWith ("libAdformTracking.a", SmartLink = true, ForceLoad = true, Frameworks = "SystemConfiguration AdSupport CoreData CoreTelephony SafariServices")]