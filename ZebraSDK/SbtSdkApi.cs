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
    [Protocol(Name = "SbtSdkApi", WrapperType = typeof(SbtSdkApiWrapper))]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SbtSetDelegate", Selector = "sbtSetDelegate:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(Zebra.ISbtSdkApiDelegate) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetOperationalMode", Selector = "sbtSetOperationalMode:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(Zebra.OperationalMode) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SubsribeForEvents", Selector = "sbtSubsribeForEvents:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(Zebra.EventType) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "UnsubsribeForEvents", Selector = "sbtUnsubsribeForEvents:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(Zebra.EventType) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAvailableScannersList", Selector = "sbtGetAvailableScannersList:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(IntPtr) }, ParameterByRef = new bool[] { true })]
    [ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetActiveScannersList", Selector = "sbtGetActiveScannersList:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(IntPtr) }, ParameterByRef = new bool[] { true })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EstablishCommunicationSession", Selector = "sbtEstablishCommunicationSession:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(int) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "TerminateCommunicationSession", Selector = "sbtTerminateCommunicationSession:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(int) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnableAvailableScannersDetection", Selector = "sbtEnableAvailableScannersDetection:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(bool) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EnableAutomaticSessionReestablishment", Selector = "sbtEnableAutomaticSessionReestablishment:forScanner:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(bool), typeof(int) }, ParameterByRef = new bool[] { false, false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ExecuteCommand", Selector = "sbtExecuteCommand:aInXML:aOutXML:forScanner:", ReturnType = typeof(Zebra.SbtResult), ParameterType = new Type[] { typeof(Zebra.OperationCode), typeof(string), typeof(string), typeof(int) }, ParameterByRef = new bool[] { false, false, true, false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetBTAddress", Selector = "sbtSetBTAddress:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
    [ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetPairingBarcode", Selector = "sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:", ReturnType = typeof(UIImage), ParameterType = new Type[] { typeof(Zebra.BarcodeType), typeof(Zebra.ComProtocol), typeof(Zebra.DefaultStatus), typeof(string), typeof(CGRect) }, ParameterByRef = new bool[] { false, false, false, false, false })]
    [ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "Version", Selector = "sbtGetVersion", PropertyType = typeof(string), GetterSelector = "sbtGetVersion", ArgumentSemantic = ArgumentSemantic.None)]
    public interface ISbtSdkApi : INativeObject, IDisposable
    {
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtSetDelegate:")]
        [Preserve(Conditional = true)]
        SbtResult SbtSetDelegate(ISbtSdkApiDelegate @delegate);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtSetOperationalMode:")]
        [Preserve(Conditional = true)]
        SbtResult SetOperationalMode(OperationalMode operationalMode);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtSubsribeForEvents:")]
        [Preserve(Conditional = true)]
        SbtResult SubsribeForEvents(EventType sdkEventsMask);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtUnsubsribeForEvents:")]
        [Preserve(Conditional = true)]
        SbtResult UnsubsribeForEvents(EventType sdkEventsMask);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEstablishCommunicationSession:")]
        [Preserve(Conditional = true)]
        SbtResult EstablishCommunicationSession(int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtTerminateCommunicationSession:")]
        [Preserve(Conditional = true)]
        SbtResult TerminateCommunicationSession(int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEnableAvailableScannersDetection:")]
        [Preserve(Conditional = true)]
        SbtResult EnableAvailableScannersDetection(bool enable);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtEnableAutomaticSessionReestablishment:forScanner:")]
        [Preserve(Conditional = true)]
        SbtResult EnableAutomaticSessionReestablishment(bool enable, int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtExecuteCommand:aInXML:aOutXML:forScanner:")]
        [Preserve(Conditional = true)]
        SbtResult ExecuteCommand(OperationCode opCode, string inXML, out string outXML, int scannerID);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtSetBTAddress:")]
        [Preserve(Conditional = true)]
        void SetBTAddress(string bluetoothAddress);

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [Export("sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:")]
        [Preserve(Conditional = true)]
        global::UIKit.UIImage GetPairingBarcode(BarcodeType barcodeType, ComProtocol comProtocol, DefaultStatus defaultStatus, string bluetoothAddress, CGRect imageFrame);

        [Preserve(Conditional = true)]
        string Version
        {
            [Export("sbtGetVersion")]
            get;
        }

    }

    public static partial class SbtSdkApi_Extensions
    {
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static SbtResult GetAvailableScannersList(this ISbtSdkApi This, ref global::System.IntPtr availableScannersList)
        {
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_ref_IntPtr(This.Handle, Selector.GetHandle("sbtGetAvailableScannersList:"), ref availableScannersList);
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public static SbtResult GetActiveScannersList(this ISbtSdkApi This, ref global::System.IntPtr activeScannersList)
        {
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_ref_IntPtr(This.Handle, Selector.GetHandle("sbtGetActiveScannersList:"), ref activeScannersList);
        }

    }

    internal sealed class SbtSdkApiWrapper : BaseWrapper, ISbtSdkApi
    {
        [Preserve(Conditional = true)]
        public SbtSdkApiWrapper(IntPtr handle, bool owns)
            : base(handle, owns)
        {
        }

        [Export("sbtSetDelegate:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public SbtResult SbtSetDelegate(ISbtSdkApiDelegate @delegate)
        {
            if (@delegate == null)
                throw new ArgumentNullException("@delegate");
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("sbtSetDelegate:"), @delegate.Handle);
        }

        [Export("sbtSetOperationalMode:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public SbtResult SetOperationalMode(OperationalMode operationalMode)
        {
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_UInt32(this.Handle, Selector.GetHandle("sbtSetOperationalMode:"), (UInt32)operationalMode);
        }

        [Export("sbtSubsribeForEvents:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public SbtResult SubsribeForEvents(EventType sdkEventsMask)
        {
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_UInt32(this.Handle, Selector.GetHandle("sbtSubsribeForEvents:"), (UInt32)sdkEventsMask);
        }

        [Export("sbtUnsubsribeForEvents:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public SbtResult UnsubsribeForEvents(EventType sdkEventsMask)
        {
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_UInt32(this.Handle, Selector.GetHandle("sbtUnsubsribeForEvents:"), (UInt32)sdkEventsMask);
        }

        [Export("sbtEstablishCommunicationSession:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public SbtResult EstablishCommunicationSession(int scannerID)
        {
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_int(this.Handle, Selector.GetHandle("sbtEstablishCommunicationSession:"), scannerID);
        }

        [Export("sbtTerminateCommunicationSession:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public SbtResult TerminateCommunicationSession(int scannerID)
        {
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_int(this.Handle, Selector.GetHandle("sbtTerminateCommunicationSession:"), scannerID);
        }

        [Export("sbtEnableAvailableScannersDetection:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public SbtResult EnableAvailableScannersDetection(bool enable)
        {
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_bool(this.Handle, Selector.GetHandle("sbtEnableAvailableScannersDetection:"), enable);
        }

        [Export("sbtEnableAutomaticSessionReestablishment:forScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public SbtResult EnableAutomaticSessionReestablishment(bool enable, int scannerID)
        {
            return (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_bool_int(this.Handle, Selector.GetHandle("sbtEnableAutomaticSessionReestablishment:forScanner:"), enable, scannerID);
        }

        [Export("sbtExecuteCommand:aInXML:aOutXML:forScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public SbtResult ExecuteCommand(OperationCode opCode, string inXML, out string outXML, int scannerID)
        {
            if (inXML == null)
                throw new ArgumentNullException("inXML");
            IntPtr outXMLValue = IntPtr.Zero;

            var nsinXML = NSString.CreateNative(inXML);

            SbtResult ret;
            ret = (SbtResult)global::ApiDefinitions.ZebraMessaging.UInt32_objc_msgSend_int_IntPtr_ref_IntPtr_int(this.Handle, Selector.GetHandle("sbtExecuteCommand:aInXML:aOutXML:forScanner:"), (int)opCode, nsinXML, ref outXMLValue, scannerID);
            NSString.ReleaseNative(nsinXML);

            outXML = NSString.FromHandle(outXMLValue);

            return ret;
        }

        [Export("sbtSetBTAddress:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public void SetBTAddress(string bluetoothAddress)
        {
            if (bluetoothAddress == null)
                throw new ArgumentNullException("bluetoothAddress");
            var nsbluetoothAddress = NSString.CreateNative(bluetoothAddress);

            global::ApiDefinitions.ZebraMessaging.void_objc_msgSend_IntPtr(this.Handle, Selector.GetHandle("sbtSetBTAddress:"), nsbluetoothAddress);
            NSString.ReleaseNative(nsbluetoothAddress);

        }

        [Export("sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public global::UIKit.UIImage GetPairingBarcode(BarcodeType barcodeType, ComProtocol comProtocol, DefaultStatus defaultStatus, string bluetoothAddress, CGRect imageFrame)
        {
            if (bluetoothAddress == null)
                throw new ArgumentNullException("bluetoothAddress");
            var nsbluetoothAddress = NSString.CreateNative(bluetoothAddress);

            global::UIKit.UIImage ret;
            ret = Runtime.GetNSObject<global::UIKit.UIImage>(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend_int_UInt32_UInt32_IntPtr_CGRect(this.Handle, Selector.GetHandle("sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:"), (int)barcodeType, (UInt32)comProtocol, (UInt32)defaultStatus, nsbluetoothAddress, imageFrame));
            NSString.ReleaseNative(nsbluetoothAddress);

            return ret;
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public string Version
        {
            [Export("sbtGetVersion")]
            get
            {
                return NSString.FromHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSend(this.Handle, Selector.GetHandle("sbtGetVersion")));
            }

        }

    }
}
namespace Zebra
{
    [Protocol()]
    [Register("SbtSdkApi", false)]
    [Model]
    public unsafe abstract partial class SbtSdkApi : NSObject, ISbtSdkApi
    {

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        [Export("init")]
        protected SbtSdkApi() : base(NSObjectFlag.Empty)
        {
            IsDirectBinding = false;
            InitializeHandle(global::ApiDefinitions.ZebraMessaging.IntPtr_objc_msgSendSuper(this.SuperHandle, global::ObjCRuntime.Selector.GetHandle("init")), "init");
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected SbtSdkApi(NSObjectFlag t) : base(t)
        {
            IsDirectBinding = false;
        }

        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        protected internal SbtSdkApi(IntPtr handle) : base(handle)
        {
            IsDirectBinding = false;
        }

        [Export("sbtEnableAutomaticSessionReestablishment:forScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract SbtResult EnableAutomaticSessionReestablishment(bool enable, int scannerID);
        [Export("sbtEnableAvailableScannersDetection:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract SbtResult EnableAvailableScannersDetection(bool enable);
        [Export("sbtEstablishCommunicationSession:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract SbtResult EstablishCommunicationSession(int scannerID);
        [Export("sbtExecuteCommand:aInXML:aOutXML:forScanner:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract SbtResult ExecuteCommand(OperationCode opCode, string inXML, out string outXML, int scannerID);
        [Export("sbtGetActiveScannersList:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        internal virtual SbtResult GetActiveScannersList(ref global::System.IntPtr activeScannersList)
        {
            throw new You_Should_Not_Call_base_In_This_Method();
        }

        [Export("sbtGetAvailableScannersList:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        internal virtual SbtResult GetAvailableScannersList(ref global::System.IntPtr availableScannersList)
        {
            throw new You_Should_Not_Call_base_In_This_Method();
        }

        [Export("sbtGetPairingBarcode:withComProtocol:withSetDefaultStatus:withBTAddress:withImageFrame:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract global::UIKit.UIImage GetPairingBarcode(BarcodeType barcodeType, ComProtocol comProtocol, DefaultStatus defaultStatus, string bluetoothAddress, CGRect imageFrame);
        [Export("sbtSetDelegate:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract SbtResult SbtSetDelegate(ISbtSdkApiDelegate @delegate);
        [Export("sbtSetBTAddress:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract void SetBTAddress(string bluetoothAddress);
        [Export("sbtSetOperationalMode:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract SbtResult SetOperationalMode(OperationalMode operationalMode);
        [Export("sbtSubsribeForEvents:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract SbtResult SubsribeForEvents(EventType sdkEventsMask);
        [Export("sbtTerminateCommunicationSession:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract SbtResult TerminateCommunicationSession(int scannerID);
        [Export("sbtUnsubsribeForEvents:")]
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract SbtResult UnsubsribeForEvents(EventType sdkEventsMask);
        [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
        public abstract string Version
        {
            [Export("sbtGetVersion")]
            get;
        }

    } /* class SbtSdkApi */
}
