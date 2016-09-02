//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using Security;
using SceneKit;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace AdformTrackingBindingiOS {
	[Register("AdformTrackingSDK", true)]
	public unsafe partial class AdformTrackingSDK : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AdformTrackingSDK");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AdformTrackingSDK () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected AdformTrackingSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AdformTrackingSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("applicationOpenUrl:sourceApplication:")]
		[CompilerGenerated]
		public virtual bool ApplicationOpenUrl (NSUrl url, string sourceApplication)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (sourceApplication == null)
				throw new ArgumentNullException ("sourceApplication");
			var nssourceApplication = NSString.CreateNative (sourceApplication);
			
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("applicationOpenUrl:sourceApplication:"), url.Handle, nssourceApplication);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("applicationOpenUrl:sourceApplication:"), url.Handle, nssourceApplication);
			}
			NSString.ReleaseNative (nssourceApplication);
			
			return ret;
		}
		
		[Export ("sendTrackPoint:")]
		[CompilerGenerated]
		public virtual void SendTrackPoint (AFTrackPoint trackPoint)
		{
			if (trackPoint == null)
				throw new ArgumentNullException ("trackPoint");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendTrackPoint:"), trackPoint.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendTrackPoint:"), trackPoint.Handle);
			}
		}
		
		[Export ("sendTrackPoints:")]
		[CompilerGenerated]
		public virtual void SendTrackPoints (AFTrackPoint[] trackPoints)
		{
			if (trackPoints == null)
				throw new ArgumentNullException ("trackPoints");
			var nsa_trackPoints = NSArray.FromNSObjects (trackPoints);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("sendTrackPoints:"), nsa_trackPoints.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("sendTrackPoints:"), nsa_trackPoints.Handle);
			}
			nsa_trackPoints.Dispose ();
			
		}
		
		[Export ("setAppName:")]
		[CompilerGenerated]
		public virtual void SetAppName (string applicationName)
		{
			if (applicationName == null)
				throw new ArgumentNullException ("applicationName");
			var nsapplicationName = NSString.CreateNative (applicationName);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setAppName:"), nsapplicationName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setAppName:"), nsapplicationName);
			}
			NSString.ReleaseNative (nsapplicationName);
			
		}
		
		[Export ("setEnabled:")]
		[CompilerGenerated]
		public virtual void SetEnabled (bool enabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnabled:"), enabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnabled:"), enabled);
			}
		}
		
		[Export ("setHTTPSEnabled:")]
		[CompilerGenerated]
		public virtual void SetHTTPSEnabled (bool HTTPSEnabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHTTPSEnabled:"), HTTPSEnabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHTTPSEnabled:"), HTTPSEnabled);
			}
		}
		
		[Export ("setOrder:")]
		[CompilerGenerated]
		public virtual void SetOrder (AFOrder order)
		{
			if (order == null)
				throw new ArgumentNullException ("order");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setOrder:"), order.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setOrder:"), order.Handle);
			}
		}
		
		[Export ("setSendSimCardStateEnabled:")]
		[CompilerGenerated]
		public virtual void SetSendSimCardStateEnabled (bool enabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSendSimCardStateEnabled:"), enabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSendSimCardStateEnabled:"), enabled);
			}
		}
		
		[Export ("startTracking:")]
		[CompilerGenerated]
		public virtual void StartTracking (global::System.nint trackingPointId)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("startTracking:"), trackingPointId);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("startTracking:"), trackingPointId);
			}
		}
		
		[Export ("startTrackingWithIds:")]
		[CompilerGenerated]
		public virtual void StartTrackingWithIds (NSNumber[] trackingPointIds)
		{
			if (trackingPointIds == null)
				throw new ArgumentNullException ("trackingPointIds");
			var nsa_trackingPointIds = NSArray.FromNSObjects (trackingPointIds);
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startTrackingWithIds:"), nsa_trackingPointIds.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startTrackingWithIds:"), nsa_trackingPointIds.Handle);
			}
			nsa_trackingPointIds.Dispose ();
			
		}
		
		[CompilerGenerated]
		public virtual bool Enabled {
			[Export ("isEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool HTTPSEnabled {
			[Export ("isHTTPSEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHTTPSEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isHTTPSEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool SendSimCardStateEnabled {
			[Export ("isSendSimCardStateEnabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSendSimCardStateEnabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSendSimCardStateEnabled"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public static AdformTrackingSDK SharedInstance {
			[Export ("sharedInstance")]
			get {
				AdformTrackingSDK ret;
				ret =  Runtime.GetNSObject<AdformTrackingSDK> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedInstance")));
				return ret;
			}
			
		}
		
	} /* class AdformTrackingSDK */
}
