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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

namespace Zebra
{
    [Protocol(Name = "ScannerInfo", WrapperType = typeof(ScannerInfoWrapper))]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Dealloc", Selector = "dealloc")]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetScannerID", Selector = "setScannerID:", ParameterType = new Type[] { typeof(int) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetConnectionType", Selector = "setConnectionType:", ParameterType = new Type[] { typeof(int) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetAutoCommunicationSessionReestablishment", Selector = "setAutoCommunicationSessionReestablishment:", ParameterType = new Type[] { typeof(bool) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetActive", Selector = "setActive:", ParameterType = new Type[] { typeof(bool) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetAvailable", Selector = "setAvailable:", ParameterType = new Type[] { typeof(bool) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetScannerName", Selector = "setScannerName:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetScannerModel", Selector = "setScannerModel:", ParameterType = new Type[] { typeof(int) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ScannerID", Selector = "getScannerID", PropertyType = typeof(int), GetterSelector = "getScannerID", ArgumentSemantic = ArgumentSemantic.None)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ConnectionType", Selector = "getConnectionType", PropertyType = typeof(Zebra.ConnectionType), GetterSelector = "getConnectionType", ArgumentSemantic = ArgumentSemantic.None)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "AutoCommunicationSessionReestablishment", Selector = "getAutoCommunicationSessionReestablishment", PropertyType = typeof(bool), GetterSelector = "getAutoCommunicationSessionReestablishment", ArgumentSemantic = ArgumentSemantic.None)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsActive", Selector = "isActive", PropertyType = typeof(bool), GetterSelector = "isActive", ArgumentSemantic = ArgumentSemantic.None)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "IsAvailable", Selector = "isAvailable", PropertyType = typeof(bool), GetterSelector = "isAvailable", ArgumentSemantic = ArgumentSemantic.None)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ScannerName", Selector = "getScannerName", PropertyType = typeof(string), GetterSelector = "getScannerName", ArgumentSemantic = ArgumentSemantic.None)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ScannerModel", Selector = "getScannerModel", PropertyType = typeof(Zebra.DeviceModel), GetterSelector = "getScannerModel", ArgumentSemantic = ArgumentSemantic.None)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "FirmwareVersion", Selector = "firmwareVersion", PropertyType = typeof(string), GetterSelector = "firmwareVersion", SetterSelector = "setFirmwareVersion:", ArgumentSemantic = ArgumentSemantic.Retain)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "MFD", Selector = "mFD", PropertyType = typeof(string), GetterSelector = "mFD", SetterSelector = "setMFD:", ArgumentSemantic = ArgumentSemantic.Retain)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "SerialNo", Selector = "serialNo", PropertyType = typeof(string), GetterSelector = "serialNo", SetterSelector = "setSerialNo:", ArgumentSemantic = ArgumentSemantic.Retain)]
    [ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ScannerModelString", Selector = "scannerModelString", PropertyType = typeof(string), GetterSelector = "scannerModelString", SetterSelector = "setScannerModelString:", ArgumentSemantic = ArgumentSemantic.Retain)]
    public interface IScannerInfo : INativeObject, IDisposable
    {
    }

    public static partial class ScannerInfo_Extensions
    {
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void Dealloc(this IScannerInfo This)
        {
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend(This.Handle, Selector.GetHandle("dealloc"));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetScannerID(this IScannerInfo This, int scannerID)
        {
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_int(This.Handle, Selector.GetHandle("setScannerID:"), scannerID);
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetConnectionType(this IScannerInfo This, int connectionType)
        {
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_int(This.Handle, Selector.GetHandle("setConnectionType:"), connectionType);
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetAutoCommunicationSessionReestablishment(this IScannerInfo This, bool enable)
        {
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_bool(This.Handle, Selector.GetHandle("setAutoCommunicationSessionReestablishment:"), enable);
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetActive(this IScannerInfo This, bool active)
        {
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_bool(This.Handle, Selector.GetHandle("setActive:"), active);
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetAvailable(this IScannerInfo This, bool available)
        {
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_bool(This.Handle, Selector.GetHandle("setAvailable:"), available);
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetScannerName(this IScannerInfo This, string scannerName)
        {
            if (scannerName == null)
                throw new ArgumentNullException("scannerName");
            var nsscannerName = NSString.CreateNative(scannerName);

            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setScannerName:"), nsscannerName);
            NSString.ReleaseNative(nsscannerName);

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetScannerModel(this IScannerInfo This, int scannerModel)
        {
            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_int(This.Handle, Selector.GetHandle("setScannerModel:"), scannerModel);
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static int GetScannerID(this IScannerInfo This)
        {
            return global::ApiDefinitions.ZebraMessaging.int_objc_msgSend(This.Handle, Selector.GetHandle("getScannerID"));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static ConnectionType GetConnectionType(this IScannerInfo This)
        {
            return (ConnectionType)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend(This.Handle, Selector.GetHandle("getConnectionType"));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static bool GetAutoCommunicationSessionReestablishment(this IScannerInfo This)
        {
            return global::ApiDefinitions.ZebraMessaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("getAutoCommunicationSessionReestablishment"));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static bool GetIsActive(this IScannerInfo This)
        {
            return global::ApiDefinitions.ZebraMessaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isActive"));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static bool GetIsAvailable(this IScannerInfo This)
        {
            return global::ApiDefinitions.ZebraMessaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("isAvailable"));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static string GetScannerName(this IScannerInfo This)
        {
            return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("getScannerName")));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static DeviceModel GetScannerModel(this IScannerInfo This)
        {
            return (DeviceModel)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend(This.Handle, Selector.GetHandle("getScannerModel"));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static string GetFirmwareVersion(this IScannerInfo This)
        {
            return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("firmwareVersion")));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetFirmwareVersion(this IScannerInfo This, string value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            var nsvalue = NSString.CreateNative(value);

            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setFirmwareVersion:"), nsvalue);
            NSString.ReleaseNative(nsvalue);

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static string GetMFD(this IScannerInfo This)
        {
            return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("mFD")));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetMFD(this IScannerInfo This, string value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            var nsvalue = NSString.CreateNative(value);

            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setMFD:"), nsvalue);
            NSString.ReleaseNative(nsvalue);

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static string GetSerialNo(this IScannerInfo This)
        {
            return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("serialNo")));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetSerialNo(this IScannerInfo This, string value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            var nsvalue = NSString.CreateNative(value);

            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setSerialNo:"), nsvalue);
            NSString.ReleaseNative(nsvalue);

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static string GetScannerModelString(this IScannerInfo This)
        {
            return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("scannerModelString")));
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static void SetScannerModelString(this IScannerInfo This, string value)
        {
            if (value == null)
                throw new ArgumentNullException("value");
            var nsvalue = NSString.CreateNative(value);

            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setScannerModelString:"), nsvalue);
            NSString.ReleaseNative(nsvalue);

        }

    }

    internal sealed class ScannerInfoWrapper : BaseWrapper, IScannerInfo
    {
        [Preserve(Conditional = true)]
        public ScannerInfoWrapper(IntPtr handle, bool owns)
            : base(handle, owns)
        {
        }

    }
}
namespace Zebra
{
    [Protocol()]
    [Register("ScannerInfo", true)]
    public unsafe partial class ScannerInfo : NSObject, IScannerInfo
    {

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        static readonly IntPtr class_ptr = Class.GetHandle("ScannerInfo");

        public override IntPtr ClassHandle { get { return class_ptr; } }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [Export("init")]
        public ScannerInfo() : base(NSObjectFlag.Empty)
        {
            IsDirectBinding = GetType().Assembly == global::ApiDefinitions.ZebraMessaging.this_assembly;
            if (IsDirectBinding)
            {
                InitializeHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, global::ObjCRuntime.Selector.GetHandle("init")), "init");
            }
            else
            {
                InitializeHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, global::ObjCRuntime.Selector.GetHandle("init")), "init");
            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected ScannerInfo(NSObjectFlag t) : base(t)
        {
            IsDirectBinding = GetType().Assembly == global::ApiDefinitions.ZebraMessaging.this_assembly;
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected internal ScannerInfo(IntPtr handle) : base(handle)
        {
            IsDirectBinding = GetType().Assembly == global::ApiDefinitions.ZebraMessaging.this_assembly;
        }

        [Export("dealloc")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void Dealloc()
        {
            if (IsDirectBinding)
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSend(this.Handle, Selector.GetHandle("dealloc"));
            }
            else
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("dealloc"));
            }
        }

        [Export("setActive:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetActive(bool active)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_bool(this.Handle, Selector.GetHandle("setActive:"), active);
            }
            else
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_bool(this.SuperHandle, Selector.GetHandle("setActive:"), active);
            }
        }

        [Export("setAutoCommunicationSessionReestablishment:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetAutoCommunicationSessionReestablishment(bool enable)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_bool(this.Handle, Selector.GetHandle("setAutoCommunicationSessionReestablishment:"), enable);
            }
            else
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_bool(this.SuperHandle, Selector.GetHandle("setAutoCommunicationSessionReestablishment:"), enable);
            }
        }

        [Export("setAvailable:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetAvailable(bool available)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_bool(this.Handle, Selector.GetHandle("setAvailable:"), available);
            }
            else
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_bool(this.SuperHandle, Selector.GetHandle("setAvailable:"), available);
            }
        }

        [Export("setConnectionType:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetConnectionType(int connectionType)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("setConnectionType:"), connectionType);
            }
            else
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_int(this.SuperHandle, Selector.GetHandle("setConnectionType:"), connectionType);
            }
        }

        [Export("setScannerID:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetScannerID(int scannerID)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("setScannerID:"), scannerID);
            }
            else
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_int(this.SuperHandle, Selector.GetHandle("setScannerID:"), scannerID);
            }
        }

        [Export("setScannerModel:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetScannerModel(int scannerModel)
        {
            if (IsDirectBinding)
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_int(this.Handle, Selector.GetHandle("setScannerModel:"), scannerModel);
            }
            else
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_int(this.SuperHandle, Selector.GetHandle("setScannerModel:"), scannerModel);
            }
        }

        [Export("setScannerName:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual void SetScannerName(string scannerName)
        {
            if (scannerName == null)
                throw new ArgumentNullException("scannerName");
            var nsscannerName = NSString.CreateNative(scannerName);

            if (IsDirectBinding)
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setScannerName:"), nsscannerName);
            }
            else
            {
                global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setScannerName:"), nsscannerName);
            }
            NSString.ReleaseNative(nsscannerName);

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual bool AutoCommunicationSessionReestablishment
        {
            [Export("getAutoCommunicationSessionReestablishment")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinitions.ZebraMessaging.bool_objc_msgSend(this.Handle, Selector.GetHandle("getAutoCommunicationSessionReestablishment"));
                }
                else
                {
                    return global::ApiDefinitions.ZebraMessaging.bool_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getAutoCommunicationSessionReestablishment"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual ConnectionType ConnectionType
        {
            [Export("getConnectionType")]
            get
            {
                if (IsDirectBinding)
                {
                    return (ConnectionType)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend(this.Handle, Selector.GetHandle("getConnectionType"));
                }
                else
                {
                    return (ConnectionType)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getConnectionType"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string FirmwareVersion
        {
            [Export("firmwareVersion", ArgumentSemantic.Retain)]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("firmwareVersion")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("firmwareVersion")));
                }
            }

            [Export("setFirmwareVersion:", ArgumentSemantic.Retain)]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var nsvalue = NSString.CreateNative(value);

                if (IsDirectBinding)
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setFirmwareVersion:"), nsvalue);
                }
                else
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setFirmwareVersion:"), nsvalue);
                }
                NSString.ReleaseNative(nsvalue);

            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual bool IsActive
        {
            [Export("isActive")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinitions.ZebraMessaging.bool_objc_msgSend(this.Handle, Selector.GetHandle("isActive"));
                }
                else
                {
                    return global::ApiDefinitions.ZebraMessaging.bool_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("isActive"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual bool IsAvailable
        {
            [Export("isAvailable")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinitions.ZebraMessaging.bool_objc_msgSend(this.Handle, Selector.GetHandle("isAvailable"));
                }
                else
                {
                    return global::ApiDefinitions.ZebraMessaging.bool_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("isAvailable"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string MFD
        {
            [Export("mFD", ArgumentSemantic.Retain)]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("mFD")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("mFD")));
                }
            }

            [Export("setMFD:", ArgumentSemantic.Retain)]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var nsvalue = NSString.CreateNative(value);

                if (IsDirectBinding)
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setMFD:"), nsvalue);
                }
                else
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setMFD:"), nsvalue);
                }
                NSString.ReleaseNative(nsvalue);

            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual int ScannerID
        {
            [Export("getScannerID")]
            get
            {
                if (IsDirectBinding)
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSend(this.Handle, Selector.GetHandle("getScannerID"));
                }
                else
                {
                    return global::ApiDefinitions.ZebraMessaging.int_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getScannerID"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual DeviceModel ScannerModel
        {
            [Export("getScannerModel")]
            get
            {
                if (IsDirectBinding)
                {
                    return (DeviceModel)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend(this.Handle, Selector.GetHandle("getScannerModel"));
                }
                else
                {
                    return (DeviceModel)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getScannerModel"));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string ScannerModelString
        {
            [Export("scannerModelString", ArgumentSemantic.Retain)]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("scannerModelString")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("scannerModelString")));
                }
            }

            [Export("setScannerModelString:", ArgumentSemantic.Retain)]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var nsvalue = NSString.CreateNative(value);

                if (IsDirectBinding)
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setScannerModelString:"), nsvalue);
                }
                else
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setScannerModelString:"), nsvalue);
                }
                NSString.ReleaseNative(nsvalue);

            }
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string ScannerName
        {
            [Export("getScannerName")]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("getScannerName")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("getScannerName")));
                }
            }

        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public virtual string SerialNo
        {
            [Export("serialNo", ArgumentSemantic.Retain)]
            get
            {
                if (IsDirectBinding)
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("serialNo")));
                }
                else
                {
                    return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, Selector.GetHandle("serialNo")));
                }
            }

            [Export("setSerialNo:", ArgumentSemantic.Retain)]
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");
                var nsvalue = NSString.CreateNative(value);

                if (IsDirectBinding)
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("setSerialNo:"), nsvalue);
                }
                else
                {
                    global::ApiDefinitions.ZebraMessaging.void_objc_msgSendSuper_IntPtr(this.SuperHandle, Selector.GetHandle("setSerialNo:"), nsvalue);
                }
                NSString.ReleaseNative(nsvalue);

            }
        }

    } /* class ScannerInfo */
}
