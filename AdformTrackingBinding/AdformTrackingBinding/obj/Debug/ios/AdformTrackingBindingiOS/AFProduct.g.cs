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
	[Register("AFProduct", true)]
	public unsafe partial class AFProduct : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("AFProduct");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public AFProduct () : base (NSObjectFlag.Empty)
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
		protected AFProduct (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal AFProduct (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithCategoryName:categoryId:productName:productId:weight:step:productSales:productCount:custom:")]
		[CompilerGenerated]
		public AFProduct (string categoryName, string categoryId, string productName, string productId, global::System.nint weight, global::System.nint step, float productSales, global::System.nint productCount, string custom)
			: base (NSObjectFlag.Empty)
		{
			if (categoryName == null)
				throw new ArgumentNullException ("categoryName");
			if (categoryId == null)
				throw new ArgumentNullException ("categoryId");
			if (productName == null)
				throw new ArgumentNullException ("productName");
			if (productId == null)
				throw new ArgumentNullException ("productId");
			if (custom == null)
				throw new ArgumentNullException ("custom");
			var nscategoryName = NSString.CreateNative (categoryName);
			var nscategoryId = NSString.CreateNative (categoryId);
			var nsproductName = NSString.CreateNative (productName);
			var nsproductId = NSString.CreateNative (productId);
			var nscustom = NSString.CreateNative (custom);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_nint_nint_float_nint_IntPtr (this.Handle, Selector.GetHandle ("initWithCategoryName:categoryId:productName:productId:weight:step:productSales:productCount:custom:"), nscategoryName, nscategoryId, nsproductName, nsproductId, weight, step, productSales, productCount, nscustom), "initWithCategoryName:categoryId:productName:productId:weight:step:productSales:productCount:custom:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_nint_nint_float_nint_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCategoryName:categoryId:productName:productId:weight:step:productSales:productCount:custom:"), nscategoryName, nscategoryId, nsproductName, nsproductId, weight, step, productSales, productCount, nscustom), "initWithCategoryName:categoryId:productName:productId:weight:step:productSales:productCount:custom:");
			}
			NSString.ReleaseNative (nscategoryName);
			NSString.ReleaseNative (nscategoryId);
			NSString.ReleaseNative (nsproductName);
			NSString.ReleaseNative (nsproductId);
			NSString.ReleaseNative (nscustom);
			
		}
		
		[CompilerGenerated]
		public virtual string CategoryId {
			[Export ("categoryId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("categoryId")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("categoryId")));
				}
			}
			
			[Export ("setCategoryId:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCategoryId:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCategoryId:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string CategoryName {
			[Export ("categoryName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("categoryName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("categoryName")));
				}
			}
			
			[Export ("setCategoryName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCategoryName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCategoryName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Custom {
			[Export ("custom", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("custom")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("custom")));
				}
			}
			
			[Export ("setCustom:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustom:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustom:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint ProductCount {
			[Export ("productCount")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("productCount"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("productCount"));
				}
			}
			
			[Export ("setProductCount:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setProductCount:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setProductCount:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string ProductId {
			[Export ("productId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("productId")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("productId")));
				}
			}
			
			[Export ("setProductId:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProductId:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProductId:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ProductName {
			[Export ("productName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("productName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("productName")));
				}
			}
			
			[Export ("setProductName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setProductName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setProductName:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual float ProductSales {
			[Export ("productSales")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.float_objc_msgSend (this.Handle, Selector.GetHandle ("productSales"));
				} else {
					return global::ApiDefinition.Messaging.float_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("productSales"));
				}
			}
			
			[Export ("setProductSales:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_float (this.Handle, Selector.GetHandle ("setProductSales:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, Selector.GetHandle ("setProductSales:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual AFEcomerceStep Step {
			[Export ("step", ArgumentSemantic.UnsafeUnretained)]
			get {
				AFEcomerceStep ret;
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						ret = (AFEcomerceStep) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("step"));
					} else {
						ret = (AFEcomerceStep) global::ApiDefinition.Messaging.UInt32_objc_msgSend (this.Handle, Selector.GetHandle ("step"));
					}
				} else {
					if (IntPtr.Size == 8) {
						ret = (AFEcomerceStep) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("step"));
					} else {
						ret = (AFEcomerceStep) global::ApiDefinition.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("step"));
					}
				}
				return ret;
			}
			
			[Export ("setStep:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setStep:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setStep:"), (UInt32)value);
					}
				} else {
					if (IntPtr.Size == 8) {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setStep:"), (UInt64)value);
					} else {
						global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setStep:"), (UInt32)value);
					}
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Weight {
			[Export ("weight")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("weight"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("weight"));
				}
			}
			
			[Export ("setWeight:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setWeight:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setWeight:"), value);
				}
			}
		}
		
	} /* class AFProduct */
}
