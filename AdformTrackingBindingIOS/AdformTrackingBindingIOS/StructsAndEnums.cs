using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace AdformTrackingBindingiOS
{
	[Native]
	public enum AFEcomerceStep : ulong
	{
		Undefined = 0,
		View = 1,
		Basket = 2,
		Purchase = 3
	}
}
